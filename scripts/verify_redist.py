#!/usr/bin/env python3
"""Quality gates for FFmpeg.AutoGen.Redist nupkgs.

Standalone, stdlib-only. Verifies a packed FFmpeg.AutoGen.Redist nupkg against
the set of gates that would have caught DESKTOP-12084 (a fat, GPL-tainted,
SDL2-linked 7.1.1 package silently poisoning NuGet caches):

  1. manifest    - exact file-set compare of runtimes/win-x64/native/ against
                    scripts/redist-manifest.txt (catches unexpected extra files,
                    not just missing required ones).
  2. forbidden    - ffplay.exe and *.pdb must not be present. (SDL2.dll and
                    libopenal-1.dll are required payload: avdevice-if-61.dll links
                    against them and is a static import of ffmpeg.exe/ffprobe.exe.)
  3. sizes        - nupkg < 100MB; ffmpeg.exe / ffprobe.exe < 5MB each;
                    avcodec-if-*.dll < 1.5x its known baseline size.
  4. pe-imports   - ffmpeg.exe / ffprobe.exe must import avcodec-if-61.dll,
                    avutil-if-59.dll and avdevice-if-61.dll, and must not import
                    SDL2.dll directly (SDL2 is pulled in transitively via avdevice).
  5. gpl-scan     - no binary may contain evidence of a linked x264/x265 GPL
                    encoder (project banner strings, or an embedded
                    --enable-gpl / --enable-libx264 / --enable-libx265
                    configure invocation); build must be --disable-gpl
                    LGPL-only.
  6. nuspec       - package id is FFmpeg.AutoGen.Redist; version matches
                    --expected-version when given.

Usage:
    verify_redist.py <nupkg> [--expected-version X] [--update-manifest]

Exit code is non-zero if any gate fails. A per-gate PASS/FAIL report is always
printed to stdout.
"""

from __future__ import annotations

import argparse
import struct
import sys
import zipfile
from dataclasses import dataclass, field
from pathlib import Path
from xml.etree import ElementTree

SCRIPT_DIR = Path(__file__).resolve().parent
DEFAULT_MANIFEST_PATH = SCRIPT_DIR / "redist-manifest.txt"

NATIVE_PREFIX = "runtimes/win-x64/native/"

# SDL2.dll and libopenal-1.dll are legitimate payload: avdevice-if-61.dll links
# against both, and avdevice is a static import of ffmpeg.exe/ffprobe.exe. Only
# ffplay.exe (unused, its own separate consumer) and debug symbols stay banned.
FORBIDDEN_EXACT_NAMES = {"ffplay.exe"}

# ffmpeg.exe/ffprobe.exe import avdevice-if-61.dll directly; avdevice in turn pulls
# in SDL2.dll + libopenal-1.dll. The exes themselves must NOT import SDL2 directly.
REQUIRED_PE_IMPORTS = {"avcodec-if-61.dll", "avutil-if-59.dll", "avdevice-if-61.dll"}
FORBIDDEN_PE_IMPORTS = {"SDL2.dll"}
PE_CHECKED_FILES = {"ffmpeg.exe", "ffprobe.exe"}

NUPKG_MAX_BYTES = 100 * 1024 * 1024
EXE_MAX_BYTES = 5 * 1024 * 1024
# avcodec-if-61.dll is ~16MB on a healthy LGPL build; allow 50% headroom for
# codec-table growth before treating it as a fat/static-link regression.
AVCODEC_BASELINE_BYTES = 16 * 1024 * 1024
AVCODEC_MAX_BYTES = int(AVCODEC_BASELINE_BYTES * 1.5)

# NOTE: a naive scan for "x264 - core" (the bead's original suggested marker)
# produces a false positive on any vanilla FFmpeg build: libavcodec's own
# H.264 SEI parser (h264_sei.c) contains that exact literal as a compile-time
# string it compares incoming bitstream metadata against, regardless of
# whether the GPL x264 *encoder* is linked in. Verified empirically: both
# known-good --disable-gpl inputs contain "x264 - core" in avcodec-if-61.dll.
# These markers only appear when the GPL encoder object code itself is
# linked in (x264/x265 emit their own project URL / banner strings), or when
# the embedded FFmpeg configure invocation records an explicit GPL enable.
GPL_MARKERS = (
    b"--enable-gpl",
    b"--enable-libx264",
    b"--enable-libx265",
    b"videolan.org/x264",
    b"x265.org",
)

EXPECTED_PACKAGE_ID = "FFmpeg.AutoGen.Redist"


@dataclass
class GateResult:
    name: str
    passed: bool
    details: list[str] = field(default_factory=list)


def native_entries(zf: zipfile.ZipFile) -> dict[str, zipfile.ZipInfo]:
    """Top-level files directly under runtimes/win-x64/native/ (basename -> info)."""
    entries: dict[str, zipfile.ZipInfo] = {}
    for info in zf.infolist():
        if info.is_dir():
            continue
        if not info.filename.startswith(NATIVE_PREFIX):
            continue
        rest = info.filename[len(NATIVE_PREFIX):]
        if "/" in rest:
            continue  # nested path - not expected, ignored by this gate
        entries[rest] = info
    return entries


def gate_manifest(entries: dict[str, zipfile.ZipInfo], manifest_path: Path) -> GateResult:
    if not manifest_path.exists():
        return GateResult(
            "manifest", False, [f"manifest file not found: {manifest_path}"]
        )
    manifest_names = {
        line.strip()
        for line in manifest_path.read_text().splitlines()
        if line.strip() and not line.strip().startswith("#")
    }
    current_names = set(entries.keys())
    missing = sorted(manifest_names - current_names)
    extra = sorted(current_names - manifest_names)
    details = []
    for name in missing:
        details.append(f"missing (in manifest, not in package): {name}")
    for name in extra:
        details.append(f"unexpected extra file (not in manifest): {name}")
    return GateResult("manifest", not missing and not extra, details)


def gate_forbidden(zf: zipfile.ZipFile, entries: dict[str, zipfile.ZipInfo]) -> GateResult:
    details = []
    for name in sorted(entries):
        if name in FORBIDDEN_EXACT_NAMES:
            details.append(f"forbidden file present: {name}")
        elif name.lower().endswith(".pdb"):
            details.append(f"forbidden file present (*.pdb): {name}")
    # Also check the whole package, not just the native folder, in case a
    # forbidden file leaked in under a different package path.
    for info in zf.infolist():
        if info.is_dir():
            continue
        basename = info.filename.rsplit("/", 1)[-1]
        if info.filename.startswith(NATIVE_PREFIX):
            continue  # already checked above
        if basename in FORBIDDEN_EXACT_NAMES or basename.lower().endswith(".pdb"):
            details.append(f"forbidden file present outside native/: {info.filename}")
    return GateResult("forbidden-files", not details, details)


def gate_sizes(
    nupkg_path: Path, zf: zipfile.ZipFile, entries: dict[str, zipfile.ZipInfo]
) -> GateResult:
    details = []

    nupkg_size = nupkg_path.stat().st_size
    if nupkg_size >= NUPKG_MAX_BYTES:
        details.append(
            f"nupkg size {nupkg_size} bytes >= limit {NUPKG_MAX_BYTES} bytes"
        )

    for exe_name in sorted(PE_CHECKED_FILES):
        info = entries.get(exe_name)
        if info is None:
            continue  # reported by manifest/forbidden gates as missing
        if info.file_size >= EXE_MAX_BYTES:
            details.append(
                f"{exe_name} size {info.file_size} bytes >= limit {EXE_MAX_BYTES} bytes"
            )

    for name, info in entries.items():
        if name.lower().startswith("avcodec") and name.lower().endswith(".dll"):
            if info.file_size >= AVCODEC_MAX_BYTES:
                details.append(
                    f"{name} size {info.file_size} bytes >= ceiling {AVCODEC_MAX_BYTES} "
                    f"bytes ({AVCODEC_BASELINE_BYTES} baseline + 50%)"
                )

    return GateResult("sizes", not details, details)


class PeParseError(Exception):
    pass


def parse_pe_imports(data: bytes) -> set[str]:
    """Return the set of DLL names a PE image imports, via a pure-Python parse
    of the PE import directory. Supports PE32 and PE32+ (x86/x64)."""
    if len(data) < 0x40 or data[0:2] != b"MZ":
        raise PeParseError("not a PE file (missing MZ signature)")

    (e_lfanew,) = struct.unpack_from("<I", data, 0x3C)
    if data[e_lfanew : e_lfanew + 4] != b"PE\x00\x00":
        raise PeParseError("not a PE file (missing PE signature)")

    coff_off = e_lfanew + 4
    (machine, num_sections, _timestamp, _symtab, _numsyms, size_opt_hdr, _chars) = (
        struct.unpack_from("<HHIIIHH", data, coff_off)
    )

    opt_hdr_off = coff_off + 20
    (magic,) = struct.unpack_from("<H", data, opt_hdr_off)
    if magic == 0x10B:
        is_pe32_plus = False
    elif magic == 0x20B:
        is_pe32_plus = True
    else:
        raise PeParseError(f"unrecognized optional header magic: {magic:#x}")

    # NumberOfRvaAndSizes lives at a fixed offset depending on PE32 vs PE32+.
    num_rva_sizes_off = opt_hdr_off + (0x5C if not is_pe32_plus else 0x6C)
    (num_rva_and_sizes,) = struct.unpack_from("<I", data, num_rva_sizes_off)

    data_dir_off = num_rva_sizes_off + 4
    if num_rva_and_sizes < 2:
        return set()  # no import directory entry present

    import_dir_entry_off = data_dir_off + 1 * 8  # DataDirectory[1] = Import Table
    import_rva, import_size = struct.unpack_from("<II", data, import_dir_entry_off)
    if import_rva == 0 or import_size == 0:
        return set()

    sections_off = opt_hdr_off + size_opt_hdr
    sections = []
    for i in range(num_sections):
        off = sections_off + i * 40
        (
            _name,
            virtual_size,
            virtual_address,
            size_of_raw_data,
            ptr_to_raw_data,
            _p_reloc,
            _p_line,
            _n_reloc,
            _n_line,
            _chars,
        ) = struct.unpack_from("<8sIIIIIIHHI", data, off)
        sections.append((virtual_address, virtual_size, ptr_to_raw_data, size_of_raw_data))

    def rva_to_offset(rva: int) -> int:
        for virtual_address, virtual_size, ptr_to_raw_data, size_of_raw_data in sections:
            span = max(virtual_size, size_of_raw_data)
            if virtual_address <= rva < virtual_address + span:
                return ptr_to_raw_data + (rva - virtual_address)
        raise PeParseError(f"RVA {rva:#x} not within any section")

    def read_cstr(offset: int) -> str:
        end = data.index(b"\x00", offset)
        return data[offset:end].decode("ascii", errors="replace")

    imports: set[str] = set()
    descriptor_size = 20
    base_off = rva_to_offset(import_rva)
    i = 0
    while True:
        entry_off = base_off + i * descriptor_size
        (orig_first_thunk, _ts, _fwd_chain, name_rva, _first_thunk) = struct.unpack_from(
            "<IIIII", data, entry_off
        )
        if orig_first_thunk == 0 and name_rva == 0 and _first_thunk == 0:
            break
        if name_rva:
            imports.add(read_cstr(rva_to_offset(name_rva)))
        i += 1
        if i > 4096:
            raise PeParseError("import descriptor table did not terminate")

    return imports


def gate_pe_imports(zf: zipfile.ZipFile, entries: dict[str, zipfile.ZipInfo]) -> GateResult:
    details = []
    for exe_name in sorted(PE_CHECKED_FILES):
        info = entries.get(exe_name)
        if info is None:
            continue  # reported by manifest/forbidden gates as missing
        data = zf.read(info)
        try:
            imports = parse_pe_imports(data)
        except PeParseError as ex:
            details.append(f"{exe_name}: failed to parse PE imports ({ex})")
            continue

        missing_required = REQUIRED_PE_IMPORTS - imports
        for dll in sorted(missing_required):
            details.append(f"{exe_name}: does not import required {dll}")

        forbidden_present = FORBIDDEN_PE_IMPORTS & imports
        for dll in sorted(forbidden_present):
            details.append(f"{exe_name}: imports forbidden {dll}")

    return GateResult("pe-imports", not details, details)


def gate_gpl_scan(zf: zipfile.ZipFile, entries: dict[str, zipfile.ZipInfo]) -> GateResult:
    details = []
    for name in sorted(entries):
        info = entries[name]
        data = zf.read(info)
        for marker in GPL_MARKERS:
            if marker in data:
                details.append(
                    f"{name}: contains GPL marker string {marker!r} "
                    f"(build must be --disable-gpl LGPL-only)"
                )
    return GateResult("gpl-scan", not details, details)


def gate_nuspec(zf: zipfile.ZipFile, expected_version: str | None) -> GateResult:
    nuspec_names = [
        n for n in zf.namelist() if n.lower().endswith(".nuspec") and "/" not in n
    ]
    if not nuspec_names:
        return GateResult("nuspec", False, ["no .nuspec file found at package root"])
    if len(nuspec_names) > 1:
        return GateResult(
            "nuspec", False, [f"multiple .nuspec files found: {nuspec_names}"]
        )

    raw = zf.read(nuspec_names[0])
    try:
        root = ElementTree.fromstring(raw)
    except ElementTree.ParseError as ex:
        return GateResult("nuspec", False, [f"failed to parse nuspec XML: {ex}"])

    # nuspec uses a namespaced root; find metadata/id and metadata/version
    # regardless of the exact namespace URI.
    def find_child(parent, tag: str):
        for child in parent:
            local = child.tag.rsplit("}", 1)[-1]
            if local == tag:
                return child
        return None

    metadata = find_child(root, "metadata")
    if metadata is None:
        return GateResult("nuspec", False, ["<metadata> element not found in nuspec"])

    id_el = find_child(metadata, "id")
    version_el = find_child(metadata, "version")

    details = []
    package_id = id_el.text.strip() if id_el is not None and id_el.text else None
    if package_id != EXPECTED_PACKAGE_ID:
        details.append(
            f"package id is {package_id!r}, expected {EXPECTED_PACKAGE_ID!r}"
        )

    package_version = version_el.text.strip() if version_el is not None and version_el.text else None
    if expected_version is not None and package_version != expected_version:
        details.append(
            f"package version is {package_version!r}, expected {expected_version!r}"
        )

    return GateResult("nuspec", not details, details)


def update_manifest(entries: dict[str, zipfile.ZipInfo], manifest_path: Path) -> None:
    lines = sorted(entries.keys())
    manifest_path.write_text("\n".join(lines) + "\n")
    print(f"Wrote {len(lines)} entries to {manifest_path}")


def print_report(results: list[GateResult]) -> bool:
    all_passed = True
    for result in results:
        status = "PASS" if result.passed else "FAIL"
        print(f"[{status}] {result.name}")
        for line in result.details:
            print(f"    {line}")
        if not result.passed:
            all_passed = False
    return all_passed


def run_gates(
    nupkg_path: Path, expected_version: str | None, manifest_path: Path
) -> list[GateResult]:
    with zipfile.ZipFile(nupkg_path) as zf:
        entries = native_entries(zf)
        return [
            gate_manifest(entries, manifest_path),
            gate_forbidden(zf, entries),
            gate_sizes(nupkg_path, zf, entries),
            gate_pe_imports(zf, entries),
            gate_gpl_scan(zf, entries),
            gate_nuspec(zf, expected_version),
        ]


def main(argv: list[str]) -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("nupkg", type=Path, help="path to the .nupkg file to verify")
    parser.add_argument(
        "--expected-version",
        default=None,
        help="fail the nuspec gate if the package version does not match exactly",
    )
    parser.add_argument(
        "--update-manifest",
        action="store_true",
        help=(
            "regenerate scripts/redist-manifest.txt from this nupkg's "
            "runtimes/win-x64/native/ listing instead of verifying it, and exit"
        ),
    )
    args = parser.parse_args(argv)

    if not args.nupkg.exists():
        print(f"error: {args.nupkg} does not exist", file=sys.stderr)
        return 2

    if args.update_manifest:
        with zipfile.ZipFile(args.nupkg) as zf:
            entries = native_entries(zf)
        update_manifest(entries, DEFAULT_MANIFEST_PATH)
        return 0

    results = run_gates(args.nupkg, args.expected_version, DEFAULT_MANIFEST_PATH)
    all_passed = print_report(results)
    return 0 if all_passed else 1


if __name__ == "__main__":
    raise SystemExit(main(sys.argv[1:]))

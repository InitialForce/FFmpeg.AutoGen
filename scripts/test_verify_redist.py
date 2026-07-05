#!/usr/bin/env python3
"""Self-test for verify_redist.py.

Builds small synthetic nupkg fixtures entirely in-memory (including a
hand-rolled minimal PE32+ executable with a real, parseable import table) so
each gate can be proven to pass on good input and fail on doctored input,
without depending on the real multi-MB FFmpeg binaries.

Run with: python3 scripts/test_verify_redist.py
"""

from __future__ import annotations

import contextlib
import io
import struct
import sys
import tempfile
import unittest
import zipfile
from pathlib import Path
from unittest import mock

sys.path.insert(0, str(Path(__file__).resolve().parent))
import verify_redist as vr  # noqa: E402


def build_minimal_pe(imported_dlls: list[str], extra_padding: int = 0) -> bytes:
    """Build a minimal, structurally-valid PE32+ image whose import directory
    lists exactly `imported_dlls`. Not loadable by Windows (no real code/DOS
    stub) but fully parseable by verify_redist.parse_pe_imports, which is all
    that's being exercised here."""
    HEADERS_SIZE = 512
    SECTION_RVA = HEADERS_SIZE  # identity-map RVA == file offset for simplicity

    num_descriptors = len(imported_dlls) + 1  # +1 for the null terminator entry
    desc_table_size = num_descriptors * 20
    names_start = SECTION_RVA + desc_table_size

    name_bytes = bytearray()
    name_rvas = []
    cursor = names_start
    for dll in imported_dlls:
        name_rvas.append(cursor)
        encoded = dll.encode("ascii") + b"\x00"
        name_bytes += encoded
        cursor += len(encoded)

    desc_bytes = bytearray()
    for name_rva in name_rvas:
        desc_bytes += struct.pack("<IIIII", 0, 0, 0, name_rva, 0)
    desc_bytes += struct.pack("<IIIII", 0, 0, 0, 0, 0)  # terminator

    section_payload = bytes(desc_bytes) + bytes(name_bytes)
    section_size = len(section_payload)

    dos = bytearray(64)
    dos[0:2] = b"MZ"
    struct.pack_into("<I", dos, 0x3C, 64)

    size_opt_hdr = 112 + 16 * 8  # fixed part + 16 data directories
    coff = struct.pack(
        "<HHIIIHH",
        0x8664,  # Machine: x64
        1,  # NumberOfSections
        0,
        0,
        0,
        size_opt_hdr,
        0x0022,
    )

    opt_fixed = struct.pack(
        "<HBBIIIIIQIIHHHHHHIIIIHHQQQQII",
        0x20B,  # Magic: PE32+
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,  # ImageBase
        0x1000,  # SectionAlignment
        0x200,  # FileAlignment
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        HEADERS_SIZE + section_size,  # SizeOfImage
        HEADERS_SIZE,  # SizeOfHeaders
        0,
        3,  # Subsystem: console
        0,
        0,
        0,
        0,
        0,
        0,  # LoaderFlags
        16,  # NumberOfRvaAndSizes
    )
    data_dirs = bytearray(16 * 8)
    struct.pack_into("<II", data_dirs, 1 * 8, SECTION_RVA, desc_table_size)
    optional_header = opt_fixed + bytes(data_dirs)
    assert len(optional_header) == size_opt_hdr

    section_header = struct.pack(
        "<8sIIIIIIHHI",
        b".idata\x00\x00",
        section_size,  # VirtualSize
        SECTION_RVA,  # VirtualAddress
        section_size,  # SizeOfRawData
        SECTION_RVA,  # PointerToRawData (identity-mapped)
        0,
        0,
        0,
        0,
        0x40000040,  # INITIALIZED_DATA | MEM_READ
    )

    header_blob = bytearray(dos) + b"PE\x00\x00" + coff + optional_header + section_header
    assert len(header_blob) <= HEADERS_SIZE
    header_blob += b"\x00" * (HEADERS_SIZE - len(header_blob))

    return bytes(header_blob) + section_payload + b"\x00" * extra_padding


GOOD_FFMPEG_IMPORTS = [
    "avcodec-if-61.dll",
    "avutil-if-59.dll",
    "avdevice-if-61.dll",
    "KERNEL32.dll",
]

BASELINE_FILES = {
    "ffmpeg.exe": build_minimal_pe(GOOD_FFMPEG_IMPORTS),
    "ffprobe.exe": build_minimal_pe(GOOD_FFMPEG_IMPORTS),
    "avcodec-if-61.dll": b"\xaa" * 1000,
    "avutil-if-59.dll": b"\xaa" * 1000,
    "swscale-if-8.dll": b"\xaa" * 1000,
}


def build_nupkg(
    path: Path,
    native_files: dict[str, bytes],
    nuspec_id: str = "FFmpeg.AutoGen.Redist",
    nuspec_version: str = "7.1.2",
) -> Path:
    nuspec = (
        '<?xml version="1.0" encoding="utf-8"?>\n'
        '<package xmlns="http://schemas.microsoft.com/packaging/2011/08/nuspec.xsd">\n'
        "  <metadata>\n"
        f"    <id>{nuspec_id}</id>\n"
        f"    <version>{nuspec_version}</version>\n"
        "  </metadata>\n"
        "</package>\n"
    )
    with zipfile.ZipFile(path, "w", zipfile.ZIP_DEFLATED) as zf:
        zf.writestr(f"{nuspec_id}.nuspec", nuspec)
        for name, content in native_files.items():
            zf.writestr(f"{vr.NATIVE_PREFIX}{name}", content)
    return path


class VerifyRedistTests(unittest.TestCase):
    def setUp(self):
        self.tmp = tempfile.TemporaryDirectory()
        self.tmp_path = Path(self.tmp.name)

    def tearDown(self):
        self.tmp.cleanup()

    def _manifest(self, names) -> Path:
        manifest_path = self.tmp_path / "manifest.txt"
        manifest_path.write_text("\n".join(sorted(names)) + "\n")
        return manifest_path

    def _run(self, files, manifest_names=None, expected_version=None, nuspec_id=None, nuspec_version=None):
        kwargs = {}
        if nuspec_id is not None:
            kwargs["nuspec_id"] = nuspec_id
        if nuspec_version is not None:
            kwargs["nuspec_version"] = nuspec_version
        nupkg = build_nupkg(self.tmp_path / "test.nupkg", files, **kwargs)
        manifest = self._manifest(manifest_names if manifest_names is not None else files.keys())
        return {r.name: r for r in vr.run_gates(nupkg, expected_version, manifest)}

    def _assert_only_failed(self, results, failed_gate):
        for name, result in results.items():
            if name == failed_gate:
                self.assertFalse(result.passed, f"expected gate {name!r} to FAIL")
            else:
                self.assertTrue(
                    result.passed, f"expected gate {name!r} to PASS, got: {result.details}"
                )

    # --- baseline: everything should pass ---

    def test_known_good_all_gates_pass(self):
        results = self._run(BASELINE_FILES, expected_version="7.1.2")
        for name, result in results.items():
            self.assertTrue(result.passed, f"gate {name!r} unexpectedly failed: {result.details}")

    # --- gate 1: manifest ---

    def test_manifest_gate_fails_on_unexpected_extra_file(self):
        doctored = dict(BASELINE_FILES)
        doctored["sneaky-extra.dll"] = b"\x00" * 10
        results = self._run(doctored, manifest_names=BASELINE_FILES.keys())
        self._assert_only_failed(results, "manifest")
        self.assertTrue(
            any("sneaky-extra.dll" in d for d in results["manifest"].details)
        )

    def test_manifest_gate_fails_on_missing_file(self):
        doctored = dict(BASELINE_FILES)
        del doctored["swscale-if-8.dll"]
        results = self._run(doctored, manifest_names=BASELINE_FILES.keys())
        self._assert_only_failed(results, "manifest")
        self.assertTrue(
            any("swscale-if-8.dll" in d for d in results["manifest"].details)
        )

    # --- gate 2: forbidden files ---

    def test_forbidden_gate_fails_on_ffplay(self):
        doctored = dict(BASELINE_FILES)
        doctored["ffplay.exe"] = b"\x00" * 10
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "forbidden-files")

    def test_forbidden_gate_allows_sdl2_and_openal(self):
        # avdevice-if-61.dll links SDL2.dll + libopenal-1.dll, and avdevice is a
        # static import of the exes, so both DLLs are required payload now.
        allowed = dict(BASELINE_FILES)
        allowed["SDL2.dll"] = b"\x00" * 10
        allowed["libopenal-1.dll"] = b"\x00" * 10
        results = self._run(allowed, manifest_names=allowed.keys())
        self.assertTrue(results["forbidden-files"].passed)

    def test_forbidden_gate_fails_on_pdb(self):
        doctored = dict(BASELINE_FILES)
        doctored["avcodec-if-61.pdb"] = b"\x00" * 10
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "forbidden-files")

    # --- gate 3: sizes ---

    def test_size_gate_fails_on_inflated_exe(self):
        doctored = dict(BASELINE_FILES)
        doctored["ffmpeg.exe"] = build_minimal_pe(GOOD_FFMPEG_IMPORTS, extra_padding=vr.EXE_MAX_BYTES)
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "sizes")
        self.assertTrue(any("ffmpeg.exe" in d for d in results["sizes"].details))

    def test_size_gate_fails_on_inflated_avcodec(self):
        doctored = dict(BASELINE_FILES)
        doctored["avcodec-if-61.dll"] = b"\xaa" * (vr.AVCODEC_MAX_BYTES + 1)
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "sizes")
        self.assertTrue(any("avcodec-if-61.dll" in d for d in results["sizes"].details))

    def test_size_gate_fails_on_oversized_nupkg(self):
        # Building an actual >100MB nupkg on disk is wasteful; patch the
        # threshold instead to exercise the same comparison against the
        # small baseline package.
        with mock.patch.object(vr, "NUPKG_MAX_BYTES", 10):
            results = self._run(BASELINE_FILES, manifest_names=BASELINE_FILES.keys())
        self._assert_only_failed(results, "sizes")

    # --- gate 4: PE imports ---

    def test_pe_imports_gate_fails_on_missing_required_dll(self):
        doctored = dict(BASELINE_FILES)
        doctored["ffmpeg.exe"] = build_minimal_pe(["avutil-if-59.dll", "KERNEL32.dll"])
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "pe-imports")
        self.assertTrue(
            any("avcodec-if-61.dll" in d for d in results["pe-imports"].details)
        )

    def test_pe_imports_gate_fails_on_sdl2_import(self):
        doctored = dict(BASELINE_FILES)
        doctored["ffprobe.exe"] = build_minimal_pe(GOOD_FFMPEG_IMPORTS + ["SDL2.dll"])
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "pe-imports")
        self.assertTrue(
            any("SDL2.dll" in d for d in results["pe-imports"].details)
        )

    # --- gate 5: GPL scan ---

    def test_gpl_scan_fails_on_injected_x264_banner(self):
        doctored = dict(BASELINE_FILES)
        doctored["avcodec-if-61.dll"] = BASELINE_FILES["avcodec-if-61.dll"] + b"videolan.org/x264.html"
        results = self._run(doctored, manifest_names=doctored.keys())
        self._assert_only_failed(results, "gpl-scan")

    def test_gpl_scan_does_not_false_positive_on_decoder_sei_literal(self):
        # Regression guard: the bead's originally-suggested marker ("x264 -
        # core") is a compile-time literal in libavcodec's own H.264 SEI
        # parser and appears in every vanilla FFmpeg build with the H.264
        # decoder, independent of GPL encoder linkage. Confirmed empirically
        # against both real known-good inputs during implementation - do not
        # regress this false positive back in.
        doctored = dict(BASELINE_FILES)
        doctored["avcodec-if-61.dll"] = BASELINE_FILES["avcodec-if-61.dll"] + b"x264 - core 164"
        results = self._run(doctored, manifest_names=doctored.keys())
        self.assertTrue(results["gpl-scan"].passed)

    # --- gate 6: nuspec ---

    def test_nuspec_gate_fails_on_wrong_id(self):
        results = self._run(BASELINE_FILES, nuspec_id="SomeOtherPackage")
        self._assert_only_failed(results, "nuspec")

    def test_nuspec_gate_fails_on_version_mismatch(self):
        results = self._run(BASELINE_FILES, nuspec_version="7.1.2", expected_version="7.1.1")
        self._assert_only_failed(results, "nuspec")

    def test_nuspec_gate_passes_without_expected_version(self):
        results = self._run(BASELINE_FILES, nuspec_version="9.9.9", expected_version=None)
        self.assertTrue(results["nuspec"].passed)

    # --- CLI plumbing ---

    def test_update_manifest_writes_sorted_entries(self):
        nupkg = build_nupkg(self.tmp_path / "seed.nupkg", BASELINE_FILES)
        manifest_path = self.tmp_path / "generated-manifest.txt"
        with zipfile.ZipFile(nupkg) as zf:
            entries = vr.native_entries(zf)
        vr.update_manifest(entries, manifest_path)
        lines = manifest_path.read_text().splitlines()
        self.assertEqual(lines, sorted(BASELINE_FILES.keys()))

    def test_main_exit_code_zero_on_good_package(self):
        nupkg = build_nupkg(self.tmp_path / "cli-good.nupkg", BASELINE_FILES)
        manifest = self._manifest(BASELINE_FILES.keys())
        with mock.patch.object(vr, "DEFAULT_MANIFEST_PATH", manifest):
            with contextlib.redirect_stdout(io.StringIO()):
                rc = vr.main([str(nupkg), "--expected-version", "7.1.2"])
        self.assertEqual(rc, 0)

    def test_main_exit_code_nonzero_on_doctored_package(self):
        doctored = dict(BASELINE_FILES)
        doctored["ffplay.exe"] = b"\x00" * 10
        nupkg = build_nupkg(self.tmp_path / "cli-bad.nupkg", doctored)
        manifest = self._manifest(doctored.keys())
        with mock.patch.object(vr, "DEFAULT_MANIFEST_PATH", manifest):
            with contextlib.redirect_stdout(io.StringIO()):
                rc = vr.main([str(nupkg)])
        self.assertEqual(rc, 1)


if __name__ == "__main__":
    unittest.main()

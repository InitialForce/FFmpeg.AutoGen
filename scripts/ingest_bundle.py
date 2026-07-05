#!/usr/bin/env python3
"""Ingest an MSYS2 mingw-w64 "bundled" FFmpeg package into FFmpeg/.

Replaces the manual "hand-copy bundle contents into FFmpeg/" seam that caused
past stale-binary accidents. The source of truth is the MINGW64 *bundled*
package variant (mingw-w64-x86_64-ffmpeg-if-bundled-<ver>-any.pkg.tar.zst),
i.e. the same package that is committed at the repo root.

Usage:
    python3 scripts/ingest_bundle.py <bundle.pkg.tar.zst> [--apply]
    python3 scripts/ingest_bundle.py --from-release <MINGW-packages-tag> [--apply]

Without --apply this only extracts the bundle, runs sanity checks, and prints
a diff report against the committed FFmpeg/ tree -- it never writes to the
working tree. Pass --apply to perform the actual clean-replace of
FFmpeg/{bin,include,lib,share}.

Only Python stdlib is used. Decompression shells out to `zstd` + `tar`
(neither GNU tar's --zstd nor Python have a built-in zstd decoder available
here, and the `zstandard` PyPI package is intentionally not a dependency).
"""
from __future__ import annotations

import argparse
import re
import shutil
import subprocess
import sys
import tempfile
from pathlib import Path

REPO_ROOT = Path(__file__).resolve().parent.parent
FFMPEG_DIR = REPO_ROOT / "FFmpeg"
PAYLOAD_DIR_NAME = "mingw64"
INGESTED_SUBDIRS = ("bin", "include", "lib", "share")

# PR #1 (11de7a5, "redist: drop ffplay/SDL2/openal, allowlist packed exes")
# dropped these from FFmpeg/bin because their only consumer, ffplay.exe, is
# not packed. Upstream bundles still ship all three; ingest must keep
# dropping them so the committed tree doesn't regress.
DROPPED_BIN_FILES = {"ffplay.exe", "SDL2.dll", "libopenal-1.dll"}

# FFmpeg.AutoGen.Redist packs only these two executables (see the allowlist
# in FFmpeg.AutoGen.Redist/FFmpeg.AutoGen.Redist.csproj); any other .exe in
# the bundle (there shouldn't be one once ffplay.exe is dropped) is reported
# as an unexpected extra rather than silently dropped.
PACKED_EXES = {"ffmpeg.exe", "ffprobe.exe"}

# The seven "-if-" suffixed shared libs a complete --disable-gpl build must
# produce, one each, named "<component>-if-<soversion>.dll".
REQUIRED_AV_LIBS = (
    "avcodec",
    "avdevice",
    "avfilter",
    "avformat",
    "avutil",
    "swresample",
    "swscale",
)
AV_LIB_RE = {name: re.compile(rf"^{name}-if-\d+\.dll$") for name in REQUIRED_AV_LIBS}

# --disable-gpl must mean no x264/x265 (GPL-only codecs) linked in. Checked
# against the build configuration string FFmpeg embeds in avutil (see
# avutil_configuration()), NOT a raw substring search across all binaries:
# "x264"/"X264" legitimately appear in GPL-free builds too (H.264 decoder
# quirk-handling code, AVI/MOV fourcc tables, CLI encoder-name tables), so a
# blind grep produces false positives.
GPL_CONFIG_REQUIRED = b"--disable-gpl"
GPL_CONFIG_FORBIDDEN = (b"--enable-gpl", b"--enable-libx264", b"--enable-libx265")

MAX_PACKED_EXE_SIZE = 5 * 1024 * 1024

GH_RELEASE_REPO = "InitialForce/MINGW-packages"
BUNDLE_ASSET_PATTERN = "mingw-w64-x86_64-ffmpeg-if-bundled-*.pkg.tar.zst"


class IngestError(Exception):
    pass


def find_required_tool(name: str) -> str:
    path = shutil.which(name)
    if path is None:
        raise IngestError(
            f"required tool '{name}' not found on PATH. Ask the user to install it "
            f"(e.g. `sudo apt install {name}` on Debian/Ubuntu) -- do not install it "
            f"from this script."
        )
    return path


def download_from_release(tag: str, dest_dir: Path) -> Path:
    """Download the bundled-variant asset for a MINGW-packages release tag via gh."""
    gh = find_required_tool("gh")
    dest_dir.mkdir(parents=True, exist_ok=True)
    cmd = [
        gh, "release", "download", tag,
        "--repo", GH_RELEASE_REPO,
        "--pattern", BUNDLE_ASSET_PATTERN,
        "--dir", str(dest_dir),
        "--clobber",
    ]
    result = subprocess.run(cmd, capture_output=True, text=True)
    if result.returncode != 0:
        raise IngestError(
            f"gh release download failed for tag '{tag}':\n{result.stderr.strip()}"
        )
    matches = sorted(dest_dir.glob("mingw-w64-x86_64-ffmpeg-if-bundled-*.pkg.tar.zst"))
    if not matches:
        raise IngestError(
            f"gh release download for tag '{tag}' completed but no asset matching "
            f"'{BUNDLE_ASSET_PATTERN}' was found in {dest_dir}"
        )
    if len(matches) > 1:
        raise IngestError(
            f"multiple assets matched '{BUNDLE_ASSET_PATTERN}' for tag '{tag}': "
            f"{[m.name for m in matches]} -- expected exactly one bundled variant"
        )
    bundle_path = matches[0]

    # Best-effort checksum verification: if a sha256 sidecar was also
    # published for this asset, verify it. Not fatal if none exists -- the
    # release-publishing bead (br-ffmpeg-pipeline-61d.4) may not have shipped
    # checksums yet.
    for pattern in (f"{bundle_path.name}.sha256", f"{bundle_path.name}.sha256sum"):
        sidecar_dest = dest_dir / pattern
        check = subprocess.run(
            [gh, "release", "download", tag, "--repo", GH_RELEASE_REPO,
             "--pattern", pattern, "--dir", str(dest_dir), "--clobber"],
            capture_output=True, text=True,
        )
        if check.returncode == 0 and sidecar_dest.exists():
            verify_checksum(bundle_path, sidecar_dest)
            break

    return bundle_path


def verify_checksum(bundle_path: Path, sidecar_path: Path) -> None:
    import hashlib
    expected = sidecar_path.read_text().split()[0].strip().lower()
    actual = hashlib.sha256(bundle_path.read_bytes()).hexdigest()
    if expected != actual:
        raise IngestError(
            f"checksum mismatch for {bundle_path.name}: "
            f"expected {expected}, got {actual}"
        )
    print(f"  checksum OK ({sidecar_path.name})")


def extract_bundle(bundle_path: Path, extract_dir: Path) -> Path:
    """Extract a .pkg.tar.zst into extract_dir and return the mingw64/ payload path."""
    zstd = find_required_tool("zstd")
    tar = find_required_tool("tar")
    extract_dir.mkdir(parents=True, exist_ok=True)

    zstd_proc = subprocess.Popen(
        [zstd, "-dc", str(bundle_path)],
        stdout=subprocess.PIPE,
    )
    tar_proc = subprocess.run(
        [tar, "-x", "-C", str(extract_dir)],
        stdin=zstd_proc.stdout,
    )
    if zstd_proc.stdout is not None:
        zstd_proc.stdout.close()
    zstd_proc.wait()
    if zstd_proc.returncode != 0:
        raise IngestError(f"zstd decompression of {bundle_path} failed (exit {zstd_proc.returncode})")
    if tar_proc.returncode != 0:
        raise IngestError(f"tar extraction of {bundle_path} failed (exit {tar_proc.returncode})")

    payload_dir = extract_dir / PAYLOAD_DIR_NAME
    if not payload_dir.is_dir():
        raise IngestError(
            f"expected a '{PAYLOAD_DIR_NAME}/' directory at the root of the extracted "
            f"package, found: {sorted(p.name for p in extract_dir.iterdir())}. "
            f"This script only understands the MINGW64 bundled package layout."
        )
    return payload_dir


def read_pkginfo(extract_dir: Path) -> dict[str, str]:
    for candidate in (extract_dir / ".PKGINFO", extract_dir / PAYLOAD_DIR_NAME / ".PKGINFO"):
        if candidate.is_file():
            info: dict[str, str] = {}
            for line in candidate.read_text(errors="replace").splitlines():
                if " = " in line:
                    key, _, value = line.partition(" = ")
                    info.setdefault(key.strip(), value.strip())
            return info
    return {}


def stage_ffmpeg_tree(payload_dir: Path, staging_root: Path) -> tuple[Path, set[str]]:
    """Build the desired post-ingest FFmpeg/ tree under staging_root/FFmpeg.

    Mirrors build/extract-ffmpeg.ps1's own bin/x64 reconstruction (all *.dll
    from bin/ copied into bin/x64/) so the generator-compatibility probe path
    (FFmpeg.AutoGen.CppSharpUnsafeGenerator + FFmpegBinariesHelper) keeps
    working, while inheriting the trio-exclusion applied to bin/ itself.

    Returns (staged FFmpeg/ dir, subset of DROPPED_BIN_FILES actually present
    in the raw bundle). The dropped set is reported explicitly even when it
    produces no tree diff -- FFmpeg/bin already excludes the trio since PR #1,
    so a plain before/after diff wouldn't otherwise show that ingest is still
    dropping them from every fresh bundle.
    """
    staged_ffmpeg = staging_root / "FFmpeg"

    src_bin = payload_dir / "bin"
    dst_bin = staged_ffmpeg / "bin"
    dst_bin.mkdir(parents=True, exist_ok=True)
    dropped_found: set[str] = set()
    for entry in sorted(src_bin.iterdir()):
        if entry.name in DROPPED_BIN_FILES:
            dropped_found.add(entry.name)
            continue
        if entry.is_dir():
            # Upstream bundles ship a flat bin/ -- if a subdirectory somehow
            # appears here it's not something this script knows how to
            # reconcile with the bin/x64 reconstruction below.
            raise IngestError(
                f"unexpected subdirectory in bundle bin/: {entry.name} -- "
                f"upstream MSYS2 mingw64 bundles ship a flat bin/, this script "
                f"does not know how to merge a nested directory"
            )
        shutil.copy2(entry, dst_bin / entry.name)

    dst_x64 = dst_bin / "x64"
    dst_x64.mkdir(parents=True, exist_ok=True)
    for dll in sorted(dst_bin.glob("*.dll")):
        shutil.copy2(dll, dst_x64 / dll.name)

    for sub in ("include", "lib", "share"):
        src = payload_dir / sub
        dst = staged_ffmpeg / sub
        if src.is_dir():
            shutil.copytree(src, dst)

    return staged_ffmpeg, dropped_found


def run_sanity_checks(staged_ffmpeg: Path) -> list[str]:
    errors: list[str] = []
    staged_bin = staged_ffmpeg / "bin"

    for exe_name in PACKED_EXES:
        exe_path = staged_bin / exe_name
        if not exe_path.is_file():
            errors.append(f"missing packed executable: bin/{exe_name}")
            continue
        size = exe_path.stat().st_size
        if size >= MAX_PACKED_EXE_SIZE:
            errors.append(
                f"bin/{exe_name} is {size:,} bytes (>= {MAX_PACKED_EXE_SIZE:,}) -- "
                f"expected a small shared-linked executable; this smells statically linked"
            )

    unexpected_exes = {
        p.name for p in staged_bin.glob("*.exe")
    } - PACKED_EXES
    if unexpected_exes:
        errors.append(
            f"unexpected executable(s) in bin/ not in the packed allowlist {sorted(PACKED_EXES)}: "
            f"{sorted(unexpected_exes)}"
        )

    for name, pattern in AV_LIB_RE.items():
        matches = [p.name for p in staged_bin.glob("*.dll") if pattern.match(p.name)]
        if len(matches) == 0:
            errors.append(f"missing required '{name}-if-*' shared lib in bin/")
        elif len(matches) > 1:
            errors.append(f"multiple '{name}-if-*' candidates in bin/: {matches} -- expected exactly one")

    avutil_matches = [p for p in staged_bin.glob("*.dll") if AV_LIB_RE["avutil"].match(p.name)]
    if not avutil_matches:
        errors.append("could not locate avutil-if-*.dll to verify the --disable-gpl build configuration")
    else:
        config_data = avutil_matches[0].read_bytes()
        if GPL_CONFIG_REQUIRED not in config_data:
            errors.append(
                f"{avutil_matches[0].name} does not embed '{GPL_CONFIG_REQUIRED.decode()}' in its "
                f"build configuration string -- refusing to assume a clean build"
            )
        for bad_flag in GPL_CONFIG_FORBIDDEN:
            if bad_flag in config_data:
                errors.append(
                    f"{avutil_matches[0].name} build configuration contains "
                    f"'{bad_flag.decode()}' -- a GPL codec appears enabled"
                )

    return errors


def git_hash_stdin(repo_root: Path, relpath: str, data: bytes) -> str:
    result = subprocess.run(
        ["git", "hash-object", "--stdin", "--path", relpath],
        input=data, cwd=repo_root, capture_output=True, check=True,
    )
    return result.stdout.decode().strip()


def committed_tree(repo_root: Path) -> dict[str, tuple[str, int]]:
    """relpath -> (blob sha, size) for everything currently committed under FFmpeg/."""
    result = subprocess.run(
        ["git", "ls-tree", "-r", "-l", "HEAD", "--", "FFmpeg"],
        cwd=repo_root, capture_output=True, text=True, check=True,
    )
    tree: dict[str, tuple[str, int]] = {}
    for line in result.stdout.splitlines():
        # "<mode> <type> <sha>  <size>\t<path>"
        meta, _, path = line.partition("\t")
        parts = meta.split()
        sha, size = parts[2], int(parts[3])
        tree[path] = (sha, size)
    return tree


def staged_tree(repo_root: Path, staged_ffmpeg: Path) -> dict[str, tuple[str, int]]:
    """relpath (as it would appear under the repo, e.g. 'FFmpeg/bin/x.dll') -> (git-normalized sha, size)."""
    tree: dict[str, tuple[str, int]] = {}
    for path in sorted(staged_ffmpeg.rglob("*")):
        if path.is_file():
            relpath = "FFmpeg/" + str(path.relative_to(staged_ffmpeg)).replace("\\", "/")
            data = path.read_bytes()
            sha = git_hash_stdin(repo_root, relpath, data)
            tree[relpath] = (sha, len(data))
    return tree


def compute_diff(current: dict[str, tuple[str, int]], staged: dict[str, tuple[str, int]]):
    added = sorted(set(staged) - set(current))
    removed = sorted(set(current) - set(staged))
    changed = sorted(
        p for p in set(staged) & set(current)
        if staged[p][0] != current[p][0]
    )
    return added, removed, changed


def format_size(n: int) -> str:
    for unit in ("B", "KB", "MB", "GB"):
        if abs(n) < 1024:
            return f"{n:.0f}{unit}" if unit == "B" else f"{n:.1f}{unit}"
        n /= 1024
    return f"{n:.1f}TB"


def print_diff_report(current, staged, added, removed, changed) -> None:
    expected_dropped = {f"FFmpeg/bin/{name}" for name in DROPPED_BIN_FILES} | {
        f"FFmpeg/bin/x64/{name}" for name in ("SDL2.dll", "libopenal-1.dll")
    }

    print()
    print("=== ingest diff report ===")
    print(f"  added:   {len(added)}")
    print(f"  removed: {len(removed)}")
    print(f"  changed: {len(changed)}")
    print()

    if added:
        print("-- added --")
        for p in added:
            print(f"  + {p} ({format_size(staged[p][1])})")

    documented_removed = [p for p in removed if p in expected_dropped]
    undocumented_removed = [p for p in removed if p not in expected_dropped]

    if documented_removed:
        print("-- removed (documented: ffplay/SDL2/openal trio + stale bin/x64 copies) --")
        for p in documented_removed:
            print(f"  - {p} ({format_size(current[p][1])})")

    if undocumented_removed:
        print("-- removed (UNDOCUMENTED -- review before applying) --")
        for p in undocumented_removed:
            print(f"  - {p} ({format_size(current[p][1])})")

    if changed:
        print("-- changed --")
        for p in changed:
            old_size = current[p][1]
            new_size = staged[p][1]
            print(f"  ~ {p} ({format_size(old_size)} -> {format_size(new_size)})")

    if not (added or removed or changed):
        print("(no differences -- committed FFmpeg/ tree already matches this bundle)")
    print()

    if undocumented_removed:
        print(
            "WARNING: undocumented removals present. Investigate before --apply; "
            "this script will not silently drop anything beyond the ffplay/SDL2/openal "
            "trio and the stale bin/x64 SDL2/openal copies."
        )


def apply_clean_replace(staged_ffmpeg: Path, repo_root: Path) -> None:
    ffmpeg_dir = repo_root / "FFmpeg"
    for sub in INGESTED_SUBDIRS:
        dst = ffmpeg_dir / sub
        src = staged_ffmpeg / sub
        if dst.exists():
            shutil.rmtree(dst)
        if src.exists():
            shutil.copytree(src, dst)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    source = parser.add_mutually_exclusive_group(required=True)
    source.add_argument("bundle", nargs="?", help="path to a local mingw-w64-x86_64-ffmpeg-if-bundled-*.pkg.tar.zst")
    source.add_argument("--from-release", metavar="TAG", help="download the bundled variant from an InitialForce/MINGW-packages release tag")
    parser.add_argument("--apply", action="store_true", help="perform the clean-replace of FFmpeg/{bin,include,lib,share}. Without this flag, only report.")
    args = parser.parse_args()

    with tempfile.TemporaryDirectory(prefix="ffag-ingest-") as tmp_str:
        tmp = Path(tmp_str)
        try:
            if args.from_release:
                print(f"Downloading bundled variant for release '{args.from_release}' from {GH_RELEASE_REPO}...")
                bundle_path = download_from_release(args.from_release, tmp / "download")
            else:
                bundle_path = Path(args.bundle).resolve()
                if not bundle_path.is_file():
                    raise IngestError(f"bundle file not found: {bundle_path}")

            print(f"Extracting {bundle_path.name}...")
            extract_dir = tmp / "extract"
            payload_dir = extract_bundle(bundle_path, extract_dir)

            pkginfo = read_pkginfo(extract_dir)
            if pkginfo:
                print(f"  pkgname={pkginfo.get('pkgname', '?')} pkgver={pkginfo.get('pkgver', '?')}")

            staging_root = tmp / "staged"
            staged_ffmpeg, dropped_from_bin = stage_ffmpeg_tree(payload_dir, staging_root)

            if dropped_from_bin:
                print(
                    "Dropped during ingest (documented, PR #1 exclusion -- "
                    "ffplay.exe's only consumer, not packed by Redist): "
                    + ", ".join(sorted(dropped_from_bin))
                )
            missing_expected_drops = DROPPED_BIN_FILES - dropped_from_bin
            if missing_expected_drops:
                print(
                    "  note: bundle bin/ did not contain "
                    + ", ".join(sorted(missing_expected_drops))
                    + " -- nothing to drop for those"
                )

            print("Running sanity checks...")
            errors = run_sanity_checks(staged_ffmpeg)
            if errors:
                print("SANITY CHECKS FAILED:", file=sys.stderr)
                for e in errors:
                    print(f"  - {e}", file=sys.stderr)
                return 1
            print("  all sanity checks passed")

            print("Diffing against committed FFmpeg/ tree...")
            current = committed_tree(REPO_ROOT)
            staged = staged_tree(REPO_ROOT, staged_ffmpeg)
            added, removed, changed = compute_diff(current, staged)
            print_diff_report(current, staged, added, removed, changed)

            undocumented = [
                p for p in removed
                if p not in {f"FFmpeg/bin/{n}" for n in DROPPED_BIN_FILES}
                and p not in {f"FFmpeg/bin/x64/{n}" for n in ("SDL2.dll", "libopenal-1.dll")}
            ]

            if not args.apply:
                print("Dry run only (pass --apply to write changes). Nothing was modified.")
                return 1 if undocumented else 0

            if undocumented:
                print(
                    "Refusing to --apply: undocumented removals would be force-overwritten. "
                    "Investigate first; re-run without --apply to inspect the report.",
                    file=sys.stderr,
                )
                return 1

            print("Applying clean-replace of FFmpeg/{bin,include,lib,share}...")
            apply_clean_replace(staged_ffmpeg, REPO_ROOT)
            print("Done.")
            print()
            print("REMINDER: bump the <Version> in FFmpeg.AutoGen.Redist/FFmpeg.AutoGen.Redist.csproj")
            if pkginfo.get("pkgver"):
                print(f"  (bundle pkgver: {pkginfo['pkgver']})")
            print("REMINDER: replace the committed bundle file(s) at the repo root with this one.")
            return 0

        except IngestError as e:
            print(f"error: {e}", file=sys.stderr)
            return 1


if __name__ == "__main__":
    sys.exit(main())

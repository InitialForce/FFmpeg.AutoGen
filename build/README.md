# FFmpeg.AutoGen Build System

This directory contains the automated build system for FFmpeg.AutoGen that processes FFmpeg tar archives and produces C# bindings and redistributable NuGet packages.

## Prerequisites

### Windows (PowerShell)
- **PowerShell 5.1+** or **PowerShell Core 6+**
- **.NET SDK 6.0+**
- **Windows 10 1803+** (for built-in tar) **OR** **7-Zip** (for tar extraction)
- **Visual Studio Build Tools** or **Visual Studio** (for C++ compilation)

### Linux/macOS (Bash)
- **Bash 4.0+**
- **.NET SDK 6.0+**
- **tar** (for archive extraction)
- **GCC/Clang** (for C++ compilation)

## Windows Usage (PowerShell)

### Quick Start
```powershell
# Complete build pipeline
.\build\build-all.ps1 -FFmpegTar "ffmpeg-7.1.0.tar"

# Clean build (removes previous outputs)
.\build\build-all.ps1 -FFmpegTar "ffmpeg-7.1.0.tar" -Clean
```

### Individual Steps

#### 1. Extract FFmpeg Archive
```powershell
.\build\extract-ffmpeg.ps1 -FFmpegTar "ffmpeg-7.1.0.tar" -OutputPath ".\FFmpeg"
```

#### 2. Generate C# Bindings
```powershell
.\build\generate-bindings.ps1 -HeadersPath ".\FFmpeg\include" -BinariesPath ".\FFmpeg\bin"
```

#### 3. Create NuGet Packages
```powershell
.\build\create-packages.ps1 -StagingPath ".\FFmpeg"
```

## Linux/macOS Usage (Bash)

### Quick Start
```bash
# Complete build pipeline
./build/build-all.sh ffmpeg-7.1.0.tar

# Clean build (removes previous outputs)
./build/build-all.sh ffmpeg-7.1.0.tar --clean
```

### Individual Steps

#### 1. Extract FFmpeg Archive
```bash
./build/extract-ffmpeg.sh ffmpeg-7.1.0.tar ./FFmpeg
```

#### 2. Generate C# Bindings
```bash
./build/generate-bindings.sh ./FFmpeg/include ./FFmpeg/bin
```

#### 3. Create NuGet Packages
```bash
./build/create-packages.sh ./FFmpeg
```

## Vendoring a Native FFmpeg Bundle (`scripts/ingest_bundle.py`)

`FFmpeg/{bin,include,lib,share}` is vendored, committed binary content sourced
from the MINGW64 **bundled** package variant published by
[InitialForce/MINGW-packages](https://github.com/InitialForce/MINGW-packages)
(`mingw-w64-x86_64-ffmpeg-if-bundled-<ver>-any.pkg.tar.zst` -- the same file
committed at the repo root). Previously this was updated by hand-copying
bundle contents into `FFmpeg/`, which is what caused a past stale-binary
accident. `scripts/ingest_bundle.py` replaces that manual seam.

```bash
# From a local bundle file
python3 scripts/ingest_bundle.py mingw-w64-x86_64-ffmpeg-if-bundled-7.1-1-any.pkg.tar.zst

# Or download the bundled variant from a MINGW-packages release tag
python3 scripts/ingest_bundle.py --from-release <tag>
```

Both forms default to a **dry run**: the bundle is extracted, sanity-checked,
and diffed against the committed `FFmpeg/` tree, and a report is printed --
nothing is written. Pass `--apply` to perform the actual clean-replace of
`FFmpeg/{bin,include,lib,share}`.

Requires `zstd` and `tar` on `PATH` (stdlib-only otherwise; no `zstandard`
PyPI dependency). If `zstd` is missing the script fails fast with an
install hint rather than installing anything itself.

### What gets excluded

`ffplay.exe` exists in upstream bundles but is intentionally **not**
committed (see PR #1, `11de7a5`): it isn't packed by `FFmpeg.AutoGen.Redist`
and has no consumer in MotionCatalyst. The script drops it during ingest and
calls it out explicitly in the diff report as a documented delta, not
silently.

`SDL2.dll` and `libopenal-1.dll` are **not** excluded, despite PR #1
originally dropping them alongside `ffplay.exe` on the assumption that
`ffplay.exe` was their only consumer. That assumption was wrong:
`avdevice-if-61.dll`, hard-imported by the packed `ffmpeg.exe`/`ffprobe.exe`,
itself imports both, so dropping them broke every spawned-exe code path with
`0xC0000135` (regression against DESKTOP-12084). They're load-bearing and
ingest keeps them everywhere ffplay.exe's exclusion doesn't apply.

### The `FFmpeg/bin/x64/` tree

`FFmpeg/bin/` has two parallel DLL trees: the flat top-level `bin/` (what
`FFmpeg.AutoGen.Redist.csproj` packs) and `bin/x64/` (the same DLLs, minus
`ffplay.exe`). This is **not** duplicate cruft -- it's a load-bearing legacy
probe path:

- `build/generate-bindings.ps1`/`.sh` resolve `<BinariesPath>/x64` and pass it
  to `FFmpeg.AutoGen.CppSharpUnsafeGenerator` via `--bin`.
- `CliOptions.cs` defaults `FFmpegBinDir` to `<FFmpegDir>/bin/x64` when only
  `-i`/`FFmpegDir` is given.
- `FFmpeg.AutoGen.Example/FFmpegBinariesHelper.cs` probes `FFmpeg/bin/x64`
  (or `bin/x86`) at runtime for the `DynamicallyLoaded` bindings' native
  library path.

`ingest_bundle.py` reconstructs `bin/x64/` as a full copy of the ingested
(ffplay.exe-filtered) `bin/*.dll` set, mirroring `extract-ffmpeg.ps1`'s own
"copy DLLs to bin/x64 for generator compatibility" logic -- including
`SDL2.dll`/`libopenal-1.dll`, since they're load-bearing there too.

### Sanity checks (always run, before any diff or write)

- `ffmpeg.exe`/`ffprobe.exe` are under 5MB (confirms shared, not static, linking)
- exactly one `<component>-if-<soversion>.dll` for each of avcodec, avdevice,
  avfilter, avformat, avutil, swresample, swscale
- no `x264`/`x265` byte-string markers in any shipped `.dll`/`.exe`
  (`--disable-gpl` must mean no GPL codecs linked in)

A doctored/corrupt bundle fails these checks and the script exits non-zero
without touching `FFmpeg/`.

### After `--apply`

The script reminds you to:
1. Bump `<Version>` in `FFmpeg.AutoGen.Redist/FFmpeg.AutoGen.Redist.csproj`
2. Replace the committed bundle file(s) at the repo root with the new one(s)

## Build Outputs

### Generated Bindings
- **Location**: `./FFmpeg.AutoGen.Bindings/generated/`
- **Files**:
  - `ffmpeg.functions.facade.g.cs` - Main API with ref overloads
  - `*.g.cs` - Generated structs, enums, delegates, etc.

### NuGet Packages
- **Location**: `./packages/`
- **Packages**:
  - `FFmpeg.AutoGen.Bindings.{version}.nupkg` - C# bindings only (~300KB)
  - `FFmpeg.AutoGen.Redist.{version}.nupkg` - Native libraries (~35MB)

## Package Usage

### Bindings Only (BYO FFmpeg)
```xml
<PackageReference Include="FFmpeg.AutoGen.Bindings" Version="7.1.1" />
```

### Complete (Bindings + Native Libraries)
```xml
<PackageReference Include="FFmpeg.AutoGen.Bindings" Version="7.1.1" />
<PackageReference Include="FFmpeg.AutoGen.Redist" Version="7.1.1" />
```

## Features

### Ref Parameter Overloads
The build system generates C#-friendly ref parameter overloads for functions with double pointer parameters:

```csharp
// Original FFmpeg API
public static void av_buffer_unref(AVBufferRef** buf);

// Generated ref overload
public static void av_buffer_unref(ref AVBufferRef* buf);

// Original FFmpeg API
public static int avformat_open_input(AVFormatContext** ps, string url, AVInputFormat* fmt, AVDictionary** options);

// Generated ref overloads
public static int avformat_open_input(ref AVFormatContext* ps, string url, AVInputFormat* fmt, AVDictionary** options);
public static int avformat_open_input(AVFormatContext** ps, string url, AVInputFormat* fmt, ref AVDictionary* options);
```

### Cross-Platform Function Resolution
Supports dynamic library loading on:
- **Windows**: DLL discovery and loading
- **Linux**: SO discovery and loading
- **macOS**: Dylib discovery and loading

### Comprehensive Error Handling
- Input validation for all paths and files
- Graceful error messages with suggestions
- Exit codes for CI/CD integration

## Troubleshooting

### Windows Issues

#### "tar: command not found"
- **Solution**: Install Windows 10 1803+ or install 7-Zip
- **Alternative**: Use WSL (Windows Subsystem for Linux)

#### "dotnet: command not found"
- **Solution**: Install .NET SDK from https://dotnet.microsoft.com/download

#### PowerShell execution policy errors
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

### Linux/macOS Issues

#### Missing tar or build tools
```bash
# Ubuntu/Debian
sudo apt-get install build-essential tar

# macOS
xcode-select --install
```

#### Permission denied
```bash
chmod +x build/*.sh
```

## Architecture

```
Input: FFmpeg tar archive
   ↓
[extract-ffmpeg] → ./FFmpeg/
   ↓
[generate-bindings] → ./FFmpeg.AutoGen.Bindings/generated/
   ↓
[create-packages] → ./packages/
   ↓
Output: NuGet packages
```

The build system is designed to be:
- **Cross-platform**: Works on Windows, Linux, and macOS
- **Automated**: Single command builds everything
- **Reproducible**: Consistent outputs across environments
- **Extensible**: Easy to add new platforms or features
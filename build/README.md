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
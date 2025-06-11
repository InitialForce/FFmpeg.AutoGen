# FFmpeg.AutoGen.Redist

This package contains the native FFmpeg binaries required by FFmpeg.AutoGen binding projects.

## Usage

Add this package reference to your project to automatically include FFmpeg binaries:

```xml
<PackageReference Include="FFmpeg.AutoGen.Redist" Version="7.1.1" />
```

The FFmpeg binaries will be automatically deployed to your output directory when you build your project.

## Included Binaries

This package includes all FFmpeg native libraries, executables, and their dependencies:

### Core FFmpeg Libraries
- avcodec-if-61.dll
- avdevice-if-61.dll
- avfilter-if-10.dll
- avformat-if-61.dll
- avutil-if-59.dll
- swresample-if-5.dll
- swscale-if-8.dll

### FFmpeg Executables
- ffmpeg.exe
- ffprobe.exe
- ffplay.exe

### Dependencies
- Plus all required dependency DLLs (SDL2, codecs, etc.)

## Compatibility

- Platform: Windows x64
- Architecture: x64
- FFmpeg Version: 7.1.1
# FFmpeg.AutoGen.Redist

This package contains the native FFmpeg binaries required by FFmpeg.AutoGen binding projects.

## Usage

Add this package reference to your project to automatically include FFmpeg DLLs:

```xml
<PackageReference Include="FFmpeg.AutoGen.Redist" Version="7.1.0" />
```

The FFmpeg binaries will be automatically copied to your output directory when you build your project.

## Included Libraries

This package includes all FFmpeg native libraries and their dependencies:

- avcodec-if-61.dll
- avdevice-if-61.dll  
- avfilter-if-10.dll
- avformat-if-61.dll
- avutil-if-59.dll
- swresample-if-5.dll
- swscale-if-8.dll
- Plus all required dependency DLLs

## Compatibility

- Platform: Windows x64
- Architecture: x64
- FFmpeg Version: 7.1.1
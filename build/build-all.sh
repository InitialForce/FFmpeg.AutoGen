#!/bin/bash
set -e

# Complete FFmpeg.AutoGen build pipeline
# Usage: ./build-all.sh <ffmpeg_tar> [--clean]

FFMPEG_TAR="$1"
CLEAN_BUILD=false

if [ -z "$FFMPEG_TAR" ]; then
    echo "❌ Usage: $0 <ffmpeg_tar> [--clean]"
    echo ""
    echo "Examples:"
    echo "  $0 ffmpeg-7.1.0.tar"
    echo "  $0 ffmpeg-7.1.0.tar --clean"
    exit 1
fi

if [ "$2" = "--clean" ]; then
    CLEAN_BUILD=true
fi

echo "🚀 Starting FFmpeg.AutoGen build pipeline"
echo "📦 Input: $FFMPEG_TAR"
echo "🕒 Started: $(date '+%Y-%m-%d %H:%M:%S')"

START_TIME=$(date +%s)

# Clean build if requested
if [ "$CLEAN_BUILD" = true ]; then
    echo ""
    echo "🧹 Cleaning previous build..."
    CLEAN_PATHS=("./FFmpeg" "./packages" "./FFmpeg.AutoGen.Abstractions/generated" "./FFmpeg.AutoGen.Bindings.StaticallyLinked/generated" "./FFmpeg.AutoGen.Bindings.DynamicallyLinked/generated" "./FFmpeg.AutoGen.Bindings.DynamicallyLoaded/generated")
    for path in "${CLEAN_PATHS[@]}"; do
        if [ -d "$path" ]; then
            rm -rf "$path"
            echo "   Cleaned: $path"
        fi
    done
fi

# Step 1: Extract FFmpeg
echo ""
echo "🔸 Step 1: Extracting FFmpeg archive"
./build/extract-ffmpeg.sh "$FFMPEG_TAR" "./FFmpeg"

# Step 2: Generate bindings
echo ""
echo "🔸 Step 2: Generating C# bindings"
./build/generate-bindings.sh "./FFmpeg/include" "./FFmpeg/bin"

# Step 3: Create packages
echo ""
echo "🔸 Step 3: Creating NuGet packages"
./build/create-packages.sh "./FFmpeg"

END_TIME=$(date +%s)
DURATION=$((END_TIME - START_TIME))

echo ""
echo "🎉 Build pipeline completed successfully!"
echo "⏱️  Total time: $(printf '%d:%02d' $((DURATION/60)) $((DURATION%60)))"

# Show final output
echo ""
echo "📊 Build summary:"

BINDINGS_FILES=$(find "./FFmpeg.AutoGen.Bindings/generated" -name "*.cs" 2>/dev/null | wc -l)
if [ "$BINDINGS_FILES" -gt 0 ]; then
    echo "   Generated files: $BINDINGS_FILES"
fi

PACKAGES=$(find "./packages" -name "*.nupkg" 2>/dev/null | wc -l)
if [ "$PACKAGES" -gt 0 ]; then
    echo "   NuGet packages: $PACKAGES"
    for pkg in ./packages/*.nupkg; do
        if [ -f "$pkg" ]; then
            size=$(du -h "$pkg" | cut -f1)
            echo "     • $(basename "$pkg") ($size)"
        fi
    done
fi
#!/bin/bash
set -e

# Extract FFmpeg tar archive and prepare for code generation
# Usage: ./extract-ffmpeg.sh <ffmpeg_tar> [output_path]

FFMPEG_TAR="$1"
OUTPUT_PATH="${2:-./staging}"

if [ -z "$FFMPEG_TAR" ]; then
    echo "❌ Usage: $0 <ffmpeg_tar> [output_path]"
    exit 1
fi

if [ ! -f "$FFMPEG_TAR" ]; then
    echo "❌ FFmpeg tar file not found: $FFMPEG_TAR"
    exit 1
fi

echo "🔄 Extracting FFmpeg tar archive..."

# Create output directory
if [ -d "$OUTPUT_PATH" ]; then
    rm -rf "$OUTPUT_PATH"
fi
mkdir -p "$OUTPUT_PATH"

# Extract tar archive
echo "📦 Extracting $FFMPEG_TAR to $OUTPUT_PATH"
tar -xf "$FFMPEG_TAR" -C "$OUTPUT_PATH" --strip-components=1

# Verify extraction
REQUIRED_DIRS=("bin" "include" "lib")
for dir in "${REQUIRED_DIRS[@]}"; do
    full_path="$OUTPUT_PATH/$dir"
    if [ ! -d "$full_path" ]; then
        echo "❌ Required directory '$dir' not found in extracted archive"
        exit 1
    fi
done

echo "✅ FFmpeg extraction completed successfully"
echo "📂 Extracted to: $OUTPUT_PATH"

# Show contents
echo ""
echo "📋 Extracted contents:"
for dir in "$OUTPUT_PATH"/*; do
    if [ -d "$dir" ]; then
        count=$(find "$dir" -type f | wc -l)
        echo "   $(basename "$dir")/ ($count files)"
    fi
done
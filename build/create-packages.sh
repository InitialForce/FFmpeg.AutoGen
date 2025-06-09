#!/bin/bash
set -e

# Create FFmpeg.AutoGen NuGet packages
# Usage: ./create-packages.sh [staging_path] [configuration] [output_path]

STAGING_PATH="${1:-./FFmpeg}"
CONFIGURATION="${2:-Release}"
OUTPUT_PATH="${3:-./packages}"

echo "🔄 Creating NuGet packages..."

# Create output directory
mkdir -p "$OUTPUT_PATH"

# Copy native libraries to redist project
echo "📦 Preparing native libraries..."
REDIST_RUNTIME_PATH="./FFmpeg.AutoGen.Redist/runtimes/win-x64/native"

mkdir -p "$REDIST_RUNTIME_PATH"

# Copy DLLs from FFmpeg folder
BIN_PATH="$STAGING_PATH/bin"
if [ -d "$BIN_PATH" ]; then
    cp "$BIN_PATH"/*.dll "$REDIST_RUNTIME_PATH" 2>/dev/null || true
    DLL_COUNT=$(ls "$REDIST_RUNTIME_PATH"/*.dll 2>/dev/null | wc -l)
    echo "   Copied $DLL_COUNT DLLs"
else
    echo "⚠️  No binaries found at $BIN_PATH - using existing libraries"
fi

# Build bindings package
echo ""
echo "🔨 Building FFmpeg.AutoGen.Bindings..."
dotnet pack ./FFmpeg.AutoGen.Bindings/FFmpeg.AutoGen.Bindings.csproj \
    --configuration "$CONFIGURATION" \
    --output "$OUTPUT_PATH" \

if [ $? -ne 0 ]; then
    echo "❌ Failed to build bindings package"
    exit 1
fi

# Build redist package
echo "🔨 Building FFmpeg.AutoGen.Redist..."
dotnet pack ./FFmpeg.AutoGen.Redist/FFmpeg.AutoGen.Redist.csproj \
    --configuration "$CONFIGURATION" \
    --output "$OUTPUT_PATH" \

if [ $? -ne 0 ]; then
    echo "❌ Failed to build redist package"
    exit 1
fi

echo "✅ Package creation completed successfully"

# Show created packages
echo ""
echo "📦 Created packages:"
for package in "$OUTPUT_PATH"/*.nupkg; do
    if [ -f "$package" ]; then
        size=$(du -h "$package" | cut -f1)
        echo "   $(basename "$package") ($size)"
    fi
done

echo ""
echo "🎯 Package usage:"
echo "   Bindings only: <PackageReference Include=\"FFmpeg.AutoGen.Bindings\" Version=\"7.1.0\" />"
echo "   Complete:      <PackageReference Include=\"FFmpeg.AutoGen.Bindings\" Version=\"7.1.0\" />"
echo "                  <PackageReference Include=\"FFmpeg.AutoGen.Redist\" Version=\"7.1.0\" />"

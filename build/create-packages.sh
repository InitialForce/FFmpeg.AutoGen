#!/bin/bash
set -e

# Create FFmpeg.AutoGen NuGet packages for all projects
# Usage: ./create-packages.sh [staging_path] [configuration] [output_path]

STAGING_PATH="${1:-./FFmpeg}"
CONFIGURATION="${2:-Release}"
OUTPUT_PATH="${3:-./packages}"

echo "🔄 Creating NuGet packages for all projects..."

# Create output directory
mkdir -p "$OUTPUT_PATH"

# Define all projects to package
declare -a PACKAGE_PROJECTS=(
    "FFmpeg.AutoGen.Abstractions:./FFmpeg.AutoGen.Abstractions/FFmpeg.AutoGen.Abstractions.csproj:Shared abstractions for FFmpeg.AutoGen"
    "FFmpeg.AutoGen.Bindings.StaticallyLinked:./FFmpeg.AutoGen.Bindings.StaticallyLinked/FFmpeg.AutoGen.Bindings.StaticallyLinked.csproj:Statically linked FFmpeg bindings"
    "FFmpeg.AutoGen.Bindings.DynamicallyLinked:./FFmpeg.AutoGen.Bindings.DynamicallyLinked/FFmpeg.AutoGen.Bindings.DynamicallyLinked.csproj:Dynamically linked FFmpeg bindings"
    "FFmpeg.AutoGen.Bindings.DynamicallyLoaded:./FFmpeg.AutoGen.Bindings.DynamicallyLoaded/FFmpeg.AutoGen.Bindings.DynamicallyLoaded.csproj:Dynamically loaded FFmpeg bindings"
    "FFmpeg.AutoGen.Bindings.DllImport:./FFmpeg.AutoGen.Bindings.DllImport/FFmpeg.AutoGen.Bindings.DllImport.csproj:DllImport-based FFmpeg bindings"
)

# Build each package
for project_info in "${PACKAGE_PROJECTS[@]}"; do
    IFS=':' read -r project_name project_path project_desc <<< "$project_info"

    echo ""
    echo "🔸 Building $project_name..."

    if [ ! -f "$project_path" ]; then
        echo "❌ Project file not found: $project_path"
        exit 1
    fi

    dotnet pack "$project_path" \
        --configuration "$CONFIGURATION" \
        --output "$OUTPUT_PATH" \
        --verbosity minimal

    if [ $? -ne 0 ]; then
        echo "❌ Failed to build $project_name package"
        exit 1
    fi

    echo "   ✅ $project_name package created successfully"
done

# Also create FFmpeg.AutoGen.Redist package if it exists
REDIST_PROJECT="./FFmpeg.AutoGen.Redist/FFmpeg.AutoGen.Redist.csproj"
if [ -f "$REDIST_PROJECT" ]; then
    echo ""
    echo "🔸 Building FFmpeg.AutoGen.Redist..."

    # Copy native libraries to redist project if they exist
    REDIST_RUNTIME_PATH="./FFmpeg.AutoGen.Redist/runtimes/win-x64/native"

    mkdir -p "$REDIST_RUNTIME_PATH"

    # Copy DLLs from FFmpeg folder
    BIN_PATH="$STAGING_PATH/bin"
    if [ -d "$BIN_PATH" ]; then
        cp "$BIN_PATH"/*.dll "$REDIST_RUNTIME_PATH" 2>/dev/null || true
        DLL_COUNT=$(ls "$REDIST_RUNTIME_PATH"/*.dll 2>/dev/null | wc -l)
        if [ "$DLL_COUNT" -gt 0 ]; then
            echo "   Copied $DLL_COUNT DLLs to redist package"
        else
            echo "   ⚠️  No DLL files found at $BIN_PATH - using existing libraries"
        fi
    else
        echo "   ⚠️  No binaries found at $BIN_PATH - using existing libraries"
    fi

    dotnet pack "$REDIST_PROJECT" \
        --configuration "$CONFIGURATION" \
        --output "$OUTPUT_PATH" \
        --verbosity minimal

    if [ $? -ne 0 ]; then
        echo "❌ Failed to build FFmpeg.AutoGen.Redist package"
        exit 1
    fi

    echo "   ✅ FFmpeg.AutoGen.Redist package created successfully"
fi

echo ""
echo "✅ All packages created successfully!"

# Show created packages
echo ""
echo "📦 Created packages:"
for package in "$OUTPUT_PATH"/*.nupkg; do
    if [ -f "$package" ]; then
        size=$(du -h "$package" | cut -f1)
        echo "   • $(basename "$package") ($size)"
    fi
done

echo ""
echo "🎯 Package usage examples:"
echo "   Abstractions:        <PackageReference Include=\"FFmpeg.AutoGen.Abstractions\" Version=\"7.1.1\" />"
echo "   Statically Linked:   <PackageReference Include=\"FFmpeg.AutoGen.Bindings.StaticallyLinked\" Version=\"7.1.1\" />"
echo "   Dynamically Linked:  <PackageReference Include=\"FFmpeg.AutoGen.Bindings.DynamicallyLinked\" Version=\"7.1.1\" />"
echo "   Dynamically Loaded:  <PackageReference Include=\"FFmpeg.AutoGen.Bindings.DynamicallyLoaded\" Version=\"7.1.1\" />"
echo "   DllImport:           <PackageReference Include=\"FFmpeg.AutoGen.Bindings.DllImport\" Version=\"7.1.1\" />"
if [ -f "$REDIST_PROJECT" ]; then
    echo "   Redist (optional):   <PackageReference Include=\"FFmpeg.AutoGen.Redist\" Version=\"7.1.1\" />"
fi
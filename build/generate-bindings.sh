#!/bin/bash
set -e

# Generate FFmpeg bindings for all 4 binding projects
# Usage: ./generate-bindings.sh [headers_path] [binaries_path] [namespace]

HEADERS_PATH="${1:-./FFmpeg/include}"
BINARIES_PATH="${2:-./FFmpeg/bin}"
NAMESPACE="${3:-FFmpeg.AutoGen}"

echo "🔄 Generating FFmpeg bindings for all projects..."

# Verify input paths
if [ ! -d "$HEADERS_PATH" ]; then
    echo "❌ Headers path not found: $HEADERS_PATH"
    exit 1
fi

if [ ! -d "$BINARIES_PATH" ]; then
    echo "❌ Binaries path not found: $BINARIES_PATH"
    exit 1
fi

echo "📂 Headers:   $HEADERS_PATH"
echo "📂 Binaries:  $BINARIES_PATH"
echo "📦 Namespace: $NAMESPACE"

# Build generator if needed
echo ""
echo "🔨 Building generator..."
cd "./FFmpeg.AutoGen.CppSharpUnsafeGenerator"
dotnet build --configuration Release --verbosity quiet
if [ $? -ne 0 ]; then
    echo "❌ Failed to build generator"
    exit 1
fi
cd ..

# Define the 4 binding projects
declare -A BINDING_PROJECTS
BINDING_PROJECTS[StaticallyLinked]="./FFmpeg.AutoGen.Bindings.StaticallyLinked --staticallyLinked"
BINDING_PROJECTS[DynamicallyLinked]="./FFmpeg.AutoGen.Bindings.DynamicallyLinked --dynamicallyLinked"
BINDING_PROJECTS[DynamicallyLoaded]="./FFmpeg.AutoGen.Bindings.DynamicallyLoaded --dynamicallyLoaded"
BINDING_PROJECTS[DllImport]="./FFmpeg.AutoGen.Bindings.DllImport --dllImport"

# Generate bindings for each project
for project_name in "${!BINDING_PROJECTS[@]}"; do
    echo ""
    echo "🔸 Generating bindings for $project_name..."

    # Parse project path and args
    project_info="${BINDING_PROJECTS[$project_name]}"
    project_path=$(echo "$project_info" | cut -d' ' -f1)
    project_args=$(echo "$project_info" | cut -d' ' -f2-)

    output_path="$project_path/generated"

    # Create output directory
    mkdir -p "$output_path"

    # Run generator with project-specific arguments
    echo "   Running generator for $project_name..."
    dotnet run --project ./FFmpeg.AutoGen.CppSharpUnsafeGenerator --configuration Release -- \
        --namespace "$NAMESPACE" \
        --headers "$HEADERS_PATH" \
        --bin "$BINARIES_PATH" \
        --output "$output_path" \
        $project_args

    if [ $? -ne 0 ]; then
        echo "❌ Code generation failed for $project_name"
        exit 1
    fi

    # Show generated files for this project
    if [ -d "$output_path" ]; then
        file_count=$(find "$output_path" -name "*.cs" -type f | wc -l)
        echo "   Generated $file_count files for $project_name"
        for file in "$output_path"/*.cs; do
            if [ -f "$file" ]; then
                size=$(du -h "$file" | cut -f1)
                echo "     • $(basename "$file") ($size)"
            fi
        done
    fi
done

# Generate shared abstractions
echo ""
echo "🔸 Generating shared abstractions..."
abstractions_path="./FFmpeg.AutoGen.Abstractions/generated"

mkdir -p "$abstractions_path"

echo "   Running generator for abstractions..."
dotnet run --project ./FFmpeg.AutoGen.CppSharpUnsafeGenerator --configuration Release -- \
    --namespace "$NAMESPACE" \
    --headers "$HEADERS_PATH" \
    --bin "$BINARIES_PATH" \
    --output "$abstractions_path" \
    --abstractionsOnly

if [ $? -ne 0 ]; then
    echo "❌ Abstractions generation failed"
    exit 1
fi

# Show abstractions files
if [ -d "$abstractions_path" ]; then
    file_count=$(find "$abstractions_path" -name "*.cs" -type f | wc -l)
    echo "   Generated $file_count abstraction files"
fi

# Build all projects
echo ""
echo "🔨 Building all binding projects..."

ALL_PROJECTS=(
    "./FFmpeg.AutoGen.Abstractions"
    "./FFmpeg.AutoGen.Bindings.StaticallyLinked"
    "./FFmpeg.AutoGen.Bindings.DynamicallyLinked"
    "./FFmpeg.AutoGen.Bindings.DynamicallyLoaded"
    "./FFmpeg.AutoGen.Bindings.DllImport"
)

for project_path in "${ALL_PROJECTS[@]}"; do
    project_name=$(basename "$project_path")
    echo "   Building $project_name..."

    cd "$project_path"
    dotnet build --configuration Release --verbosity minimal
    if [ $? -ne 0 ]; then
        echo "❌ Failed to build $project_name"
        exit 1
    fi
    cd - > /dev/null
done

echo ""
echo "✅ All bindings generated and built successfully!"

# Summary
echo ""
echo "📊 Generation summary:"
for project_name in "${!BINDING_PROJECTS[@]}"; do
    project_info="${BINDING_PROJECTS[$project_name]}"
    project_path=$(echo "$project_info" | cut -d' ' -f1)
    output_path="$project_path/generated"

    if [ -d "$output_path" ]; then
        file_count=$(find "$output_path" -name "*.cs" -type f | wc -l)
        echo "   $project_name: $file_count files"
    fi
done

abstractions_file_count=0
if [ -d "$abstractions_path" ]; then
    abstractions_file_count=$(find "$abstractions_path" -name "*.cs" -type f | wc -l)
fi
echo "   Abstractions: $abstractions_file_count files"
#!/bin/bash
set -e

# Generate FFmpeg bindings using the CppSharpUnsafeGenerator
# Usage: ./generate-bindings.sh <headers_path> <binaries_path> [output_path] [namespace]

HEADERS_PATH="${1:-./FFmpeg/include}"
BINARIES_PATH="${2:-./FFmpeg/bin}"
OUTPUT_PATH="${3:-./FFmpeg.AutoGen.Bindings/generated}"
NAMESPACE="${4:-FFmpeg.AutoGen}"

echo "🔄 Generating FFmpeg bindings..."

# Verify input paths
if [ ! -d "$HEADERS_PATH" ]; then
    echo "❌ Headers path not found: $HEADERS_PATH"
    exit 1
fi

if [ ! -d "$BINARIES_PATH" ]; then
    echo "❌ Binaries path not found: $BINARIES_PATH"
    exit 1
fi

# Create output directory
mkdir -p "$OUTPUT_PATH"

echo "📂 Headers:   $HEADERS_PATH"
echo "📂 Binaries:  $BINARIES_PATH"
echo "📂 Output:    $OUTPUT_PATH"
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

# Run generator
echo "⚡ Running generator..."
dotnet run --project ./FFmpeg.AutoGen.CppSharpUnsafeGenerator --configuration Release -- \
    --namespace "$NAMESPACE" \
    --headers "$HEADERS_PATH" \
    --bin "$BINARIES_PATH" \
    --output "$OUTPUT_PATH"

if [ $? -ne 0 ]; then
    echo "❌ Code generation failed"
    exit 1
fi

# Copy required support files to bindings project
echo ""
echo "📋 Setting up bindings project..."

BINDINGS_DIR="./FFmpeg.AutoGen.Bindings"
BINDINGS_GEN_DIR="$BINDINGS_DIR/generated"

# Copy core support files from legacy project
SUPPORT_FILES=(
    "ConstCharPtrMarshaler.cs"
    "UTF8Marshaler.cs"
    "IFixedArray.cs"
    "FunctionResolverBase.cs"
    "FunctionResolverFactory.cs"
    "IFunctionResolver.cs"
)

for file in "${SUPPORT_FILES[@]}"; do
    source_path="./FFmpeg.AutoGen/$file"
    dest_path="$BINDINGS_DIR/$file"

    if [ -f "$source_path" ]; then
        cp -f "$source_path" "$dest_path"
        echo "   Copied: $file"
    fi
done

# Copy Native directory
NATIVE_SOURCE_DIR="./FFmpeg.AutoGen/Native"
NATIVE_DEST_DIR="$BINDINGS_DIR/Native"

if [ -d "$NATIVE_SOURCE_DIR" ]; then
    rm -rf "$NATIVE_DEST_DIR"
    cp -r "$NATIVE_SOURCE_DIR" "$NATIVE_DEST_DIR"
    echo "   Copied: Native directory"
fi

# Files are now generated directly to the unified Bindings project

echo "✅ Bindings generation completed successfully"

# Show generated files
echo ""
echo "📋 Generated files:"
if [ -d "$BINDINGS_GEN_DIR" ]; then
    for file in "$BINDINGS_GEN_DIR"/*.cs; do
        if [ -f "$file" ]; then
            size=$(du -h "$file" | cut -f1)
            echo "   $(basename "$file") ($size)"
        fi
    done
fi

# Build the generated bindings project
echo ""
echo "🔨 Building bindings project..."
cd "$BINDINGS_DIR"
dotnet build --configuration Release --verbosity minimal
if [ $? -ne 0 ]; then
    echo "❌ Failed to build bindings project"
    exit 1
fi
echo "✅ Bindings project built successfully"
cd ..
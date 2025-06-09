#!/usr/bin/env pwsh
param(
    [string]$HeadersPath = ".\FFmpeg\include",
    [string]$BinariesPath = ".\FFmpeg\bin",
    [string]$Namespace = "FFmpeg.AutoGen"
)

$ErrorActionPreference = "Stop"

# Generate FFmpeg bindings for all 3 binding projects
# Usage: .\generate-bindings.ps1 [-HeadersPath <headers_path>] [-BinariesPath <binaries_path>] [-Namespace <namespace>]

Write-Host "🔄 Generating FFmpeg bindings for all projects..." -ForegroundColor Blue

# Verify input paths
if (-not (Test-Path $HeadersPath)) {
    Write-Host "❌ Headers path not found: $HeadersPath" -ForegroundColor Red
    exit 1
}

if (-not (Test-Path $BinariesPath)) {
    Write-Host "❌ Binaries path not found: $BinariesPath" -ForegroundColor Red
    exit 1
}

Write-Host "📂 Headers:   $HeadersPath"
Write-Host "📂 Binaries:  $BinariesPath"
Write-Host "📦 Namespace: $Namespace"

# Build generator if needed
Write-Host ""
Write-Host "🔨 Building generator..." -ForegroundColor Yellow
Push-Location ".\FFmpeg.AutoGen.CppSharpUnsafeGenerator"
try {
    dotnet build --configuration Release --verbosity quiet
    if ($LASTEXITCODE -ne 0) {
        throw "Failed to build generator"
    }
}
finally {
    Pop-Location
}

# Define the 3 binding projects
$BindingProjects = @(
    @{
        Name = "StaticallyLinked"
        Path = ".\FFmpeg.AutoGen.Bindings.StaticallyLinked"
        OutputFile = "StaticallyLinkedBindings.g.cs"
        GeneratorArgs = @("--staticallyLinked")
    },
    @{
        Name = "DynamicallyLinked"
        Path = ".\FFmpeg.AutoGen.Bindings.DynamicallyLinked"
        OutputFile = "DynamicallyLinkedBindings.g.cs"
        GeneratorArgs = @("--dynamicallyLinked")
    },
    @{
        Name = "DynamicallyLoaded"
        Path = ".\FFmpeg.AutoGen.Bindings.DynamicallyLoaded"
        OutputFile = "DynamicallyLoadedBindings.g.cs"
        GeneratorArgs = @("--dynamicallyLoaded")
    }
)

# Generate bindings for each project
foreach ($project in $BindingProjects) {
    Write-Host ""
    Write-Host "🔸 Generating bindings for $($project.Name)..." -ForegroundColor Cyan

    $outputPath = "$($project.Path)\generated"

    # Create output directory
    if (-not (Test-Path $outputPath)) {
        New-Item -ItemType Directory -Path $outputPath -Force | Out-Null
    }

    # Run generator with project-specific arguments
    $generatorArgs = @(
        "run"
        "--project"
        ".\FFmpeg.AutoGen.CppSharpUnsafeGenerator"
        "--configuration"
        "Release"
        "--"
        "--namespace"
        $Namespace
        "--headers"
        $HeadersPath
        "--bin"
        $BinariesPath
        "--output"
        $outputPath
    ) + $project.GeneratorArgs

    Write-Host "   Running generator for $($project.Name)..."
    & dotnet @generatorArgs
    if ($LASTEXITCODE -ne 0) {
        Write-Host "❌ Code generation failed for $($project.Name)" -ForegroundColor Red
        exit 1
    }

    # Show generated files for this project
    if (Test-Path $outputPath) {
        $files = Get-ChildItem -Path $outputPath -Filter "*.cs"
        Write-Host "   Generated $($files.Count) files for $($project.Name)"
        foreach ($file in $files) {
            $size = [Math]::Round($file.Length / 1KB, 0)
            $sizeUnit = if ($size -gt 1024) { "$([Math]::Round($file.Length / 1MB, 1))MB" } else { "$($size)KB" }
            Write-Host "     • $($file.Name) ($sizeUnit)"
        }
    }
}

# Generate shared abstractions
Write-Host ""
Write-Host "🔸 Generating shared abstractions..." -ForegroundColor Cyan
$abstractionsPath = ".\FFmpeg.AutoGen.Abstractions\generated"

if (-not (Test-Path $abstractionsPath)) {
    New-Item -ItemType Directory -Path $abstractionsPath -Force | Out-Null
}

$abstractionsArgs = @(
    "run"
    "--project"
    ".\FFmpeg.AutoGen.CppSharpUnsafeGenerator"
    "--configuration"
    "Release"
    "--"
    "--namespace"
    $Namespace
    "--headers"
    $HeadersPath
    "--bin"
    $BinariesPath
    "--output"
    $abstractionsPath
    "--abstractionsOnly"
)

Write-Host "   Running generator for abstractions..."
& dotnet @abstractionsArgs
if ($LASTEXITCODE -ne 0) {
    Write-Host "❌ Abstractions generation failed" -ForegroundColor Red
    exit 1
}

# Show abstractions files
if (Test-Path $abstractionsPath) {
    $files = Get-ChildItem -Path $abstractionsPath -Filter "*.cs"
    Write-Host "   Generated $($files.Count) abstraction files"
}

# Build all projects
Write-Host ""
Write-Host "🔨 Building all binding projects..." -ForegroundColor Yellow

$AllProjects = @(
    ".\FFmpeg.AutoGen.Abstractions",
    ".\FFmpeg.AutoGen.Bindings.StaticallyLinked",
    ".\FFmpeg.AutoGen.Bindings.DynamicallyLinked",
    ".\FFmpeg.AutoGen.Bindings.DynamicallyLoaded"
)

foreach ($projectPath in $AllProjects) {
    $projectName = Split-Path -Leaf $projectPath
    Write-Host "   Building $projectName..."

    Push-Location $projectPath
    try {
        dotnet build --configuration Release --verbosity minimal
        if ($LASTEXITCODE -ne 0) {
            Write-Host "❌ Failed to build $projectName" -ForegroundColor Red
            exit 1
        }
    }
    finally {
        Pop-Location
    }
}

Write-Host ""
Write-Host "✅ All bindings generated and built successfully!" -ForegroundColor Green

# Summary
Write-Host ""
Write-Host "📊 Generation summary:" -ForegroundColor Blue
foreach ($project in $BindingProjects) {
    $outputPath = "$($project.Path)\generated"
    if (Test-Path $outputPath) {
        $fileCount = (Get-ChildItem -Path $outputPath -Filter "*.cs").Count
        Write-Host "   $($project.Name): $fileCount files"
    }
}

$abstractionsFileCount = 0
if (Test-Path $abstractionsPath) {
    $abstractionsFileCount = (Get-ChildItem -Path $abstractionsPath -Filter "*.cs").Count
}
Write-Host "   Abstractions: $abstractionsFileCount files"
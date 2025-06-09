#!/usr/bin/env pwsh
param(
    [string]$HeadersPath = ".\FFmpeg\include",
    [string]$BinariesPath = ".\FFmpeg\bin",
    [string]$Namespace = "FFmpeg.AutoGen"
)

$ErrorActionPreference = "Stop"

# Generate FFmpeg bindings for all projects
# Usage: .\generate-bindings.ps1 [-HeadersPath <headers_path>] [-BinariesPath <binaries_path>] [-Namespace <namespace>]

Write-Host "Generating FFmpeg bindings for all projects..." -ForegroundColor Blue

# Verify input paths
if (-not (Test-Path $HeadersPath)) {
    Write-Host "Headers path not found: $HeadersPath" -ForegroundColor Red
    exit 1
}

if (-not (Test-Path $BinariesPath)) {
    Write-Host "Binaries path not found: $BinariesPath" -ForegroundColor Red
    exit 1
}

Write-Host "Headers:   $HeadersPath"
Write-Host "Binaries:  $BinariesPath"
Write-Host "Namespace: $Namespace"

# Build generator if needed
Write-Host ""
Write-Host "Building generator..." -ForegroundColor Yellow
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

# Ensure output directories exist
$OutputDirs = @(
    ".\FFmpeg.AutoGen\generated",
    ".\FFmpeg.AutoGen.Abstractions\generated",
    ".\FFmpeg.AutoGen.Bindings.StaticallyLinked\generated",
    ".\FFmpeg.AutoGen.Bindings.DynamicallyLinked\generated",
    ".\FFmpeg.AutoGen.Bindings.DynamicallyLoaded\generated",
    ".\FFmpeg.AutoGen.Bindings.DllImport\generated"
)

foreach ($dir in $OutputDirs) {
    if (-not (Test-Path $dir)) {
        New-Item -ItemType Directory -Path $dir -Force | Out-Null
    }
}

# Run the generator once - it generates all binding types
Write-Host ""
Write-Host "Running FFmpeg bindings generator..." -ForegroundColor Cyan

$fullHeadersPath = Resolve-Path $HeadersPath
$fullBinariesPath = Resolve-Path "$BinariesPath\x64"
$fullOutputPath = Resolve-Path "."

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
    $fullHeadersPath.Path
    "--bin"
    $fullBinariesPath.Path
    "--output"
    $fullOutputPath.Path
)

Write-Host "   Running generator..."
& dotnet @generatorArgs
if ($LASTEXITCODE -eq 0) {
    Write-Host "Generator completed successfully" -ForegroundColor Green
} else {
    Write-Host "Generator completed with exit code: $LASTEXITCODE" -ForegroundColor Yellow
    Write-Host "Checking if files were generated despite the error..." -ForegroundColor Yellow
}

# Show generated files for each project
Write-Host ""
Write-Host "Generated files:" -ForegroundColor Green

$Projects = @(
    @{ Name = "FFmpeg.AutoGen"; Path = ".\FFmpeg.AutoGen\generated" },
    @{ Name = "Abstractions"; Path = ".\FFmpeg.AutoGen.Abstractions\generated" },
    @{ Name = "StaticallyLinked"; Path = ".\FFmpeg.AutoGen.Bindings.StaticallyLinked\generated" },
    @{ Name = "DynamicallyLinked"; Path = ".\FFmpeg.AutoGen.Bindings.DynamicallyLinked\generated" },
    @{ Name = "DynamicallyLoaded"; Path = ".\FFmpeg.AutoGen.Bindings.DynamicallyLoaded\generated" },
    @{ Name = "DllImport"; Path = ".\FFmpeg.AutoGen.Bindings.DllImport\generated" }
)

foreach ($project in $Projects) {
    if (Test-Path $project.Path) {
        $files = Get-ChildItem -Path $project.Path -Filter "*.cs"
        if ($files.Count -gt 0) {
            Write-Host "   $($project.Name): $($files.Count) files"
            foreach ($file in $files) {
                $size = [Math]::Round($file.Length / 1KB, 0)
                $sizeUnit = if ($size -gt 1024) { "$([Math]::Round($file.Length / 1MB, 1))MB" } else { "$($size)KB" }
                Write-Host "     - $($file.Name) ($sizeUnit)"
            }
        } else {
            Write-Host "   $($project.Name): No files generated" -ForegroundColor Yellow
        }
    } else {
        Write-Host "   $($project.Name): Output directory not found" -ForegroundColor Yellow
    }
}

# Build all projects
Write-Host ""
Write-Host "Building all binding projects..." -ForegroundColor Yellow

$AllProjects = @(
    ".\FFmpeg.AutoGen.Abstractions",
    ".\FFmpeg.AutoGen.Bindings.StaticallyLinked",
    ".\FFmpeg.AutoGen.Bindings.DynamicallyLinked",
    ".\FFmpeg.AutoGen.Bindings.DynamicallyLoaded",
    ".\FFmpeg.AutoGen.Bindings.DllImport"
)

foreach ($projectPath in $AllProjects) {
    $projectName = Split-Path -Leaf $projectPath
    Write-Host "   Building $projectName..."

    Push-Location $projectPath
    try {
        dotnet build --configuration Release --verbosity minimal
        if ($LASTEXITCODE -ne 0) {
            Write-Host "Failed to build $projectName" -ForegroundColor Red
            exit 1
        }
    }
    finally {
        Pop-Location
    }
}

Write-Host ""
Write-Host "All bindings generated and built successfully!" -ForegroundColor Green
#!/usr/bin/env pwsh
param(
    [string]$StagingPath = ".\FFmpeg",
    [string]$Configuration = "Release",
    [string]$OutputPath = ".\packages"
)

$ErrorActionPreference = "Stop"

# Create FFmpeg.AutoGen NuGet packages for all projects
# Usage: .\create-packages.ps1 [-StagingPath <staging_path>] [-Configuration <configuration>] [-OutputPath <output_path>]

Write-Host "Creating NuGet packages for all projects..." -ForegroundColor Blue

# Create output directory
if (-not (Test-Path $OutputPath)) {
    New-Item -ItemType Directory -Path $OutputPath -Force | Out-Null
}

# Define all projects to package
$PackageProjects = @(
    @{
        Name = "FFmpeg.AutoGen.Abstractions"
        Path = ".\FFmpeg.AutoGen.Abstractions\FFmpeg.AutoGen.Abstractions.csproj"
        Description = "Shared abstractions for FFmpeg.AutoGen"
    },
    @{
        Name = "FFmpeg.AutoGen.Bindings.StaticallyLinked"
        Path = ".\FFmpeg.AutoGen.Bindings.StaticallyLinked\FFmpeg.AutoGen.Bindings.StaticallyLinked.csproj"
        Description = "Statically linked FFmpeg bindings"
    },
    @{
        Name = "FFmpeg.AutoGen.Bindings.DynamicallyLinked"
        Path = ".\FFmpeg.AutoGen.Bindings.DynamicallyLinked\FFmpeg.AutoGen.Bindings.DynamicallyLinked.csproj"
        Description = "Dynamically linked FFmpeg bindings"
    },
    @{
        Name = "FFmpeg.AutoGen.Bindings.DynamicallyLoaded"
        Path = ".\FFmpeg.AutoGen.Bindings.DynamicallyLoaded\FFmpeg.AutoGen.Bindings.DynamicallyLoaded.csproj"
        Description = "Dynamically loaded FFmpeg bindings"
    },
    @{
        Name = "FFmpeg.AutoGen.Bindings.DllImport"
        Path = ".\FFmpeg.AutoGen.Bindings.DllImport\FFmpeg.AutoGen.Bindings.DllImport.csproj"
        Description = "DllImport-based FFmpeg bindings"
    },
    @{
        Name = "FFmpeg.AutoGen.Redist"
        Path = ".\FFmpeg.AutoGen.Redist\FFmpeg.AutoGen.Redist.csproj"
        Description = "FFmpeg native binaries redistribution package"
    }
)

# Build each package
foreach ($project in $PackageProjects) {
    Write-Host ""
    Write-Host "Building $($project.Name)..." -ForegroundColor Cyan

    if (-not (Test-Path $project.Path)) {
        Write-Host "Project file not found: $($project.Path)" -ForegroundColor Red
        exit 1
    }

    $packArgs = @(
        "pack"
        $project.Path
        "--configuration"
        $Configuration
        "--output"
        $OutputPath
        "--verbosity"
        "minimal"
    )

    & dotnet @packArgs
    if ($LASTEXITCODE -ne 0) {
        Write-Host "Failed to build $($project.Name) package" -ForegroundColor Red
        exit 1
    }

    Write-Host "   $($project.Name) package created successfully"
}


Write-Host ""
Write-Host "All packages created successfully!" -ForegroundColor Green

# Show created packages
Write-Host ""
Write-Host "Created packages:" -ForegroundColor Blue
$packages = Get-ChildItem -Path $OutputPath -Filter "*.nupkg" -ErrorAction SilentlyContinue
if ($packages.Count -eq 0) {
    Write-Host "   No packages found in $OutputPath" -ForegroundColor Yellow
} else {
    foreach ($package in $packages) {
        $size = [Math]::Round($package.Length / 1MB, 1)
        $sizeUnit = if ($size -gt 1) { "$($size)MB" } else { "$([Math]::Round($package.Length / 1KB, 0))KB" }
        Write-Host "   $($package.Name) ($sizeUnit)"
    }
}

Write-Host ""
Write-Host "Package usage examples:" -ForegroundColor Green
Write-Host "   FFmpeg.AutoGen.Abstractions"
Write-Host "   FFmpeg.AutoGen.Bindings.StaticallyLinked"
Write-Host "   FFmpeg.AutoGen.Bindings.DynamicallyLinked"
Write-Host "   FFmpeg.AutoGen.Bindings.DynamicallyLoaded"
Write-Host "   FFmpeg.AutoGen.Bindings.DllImport"
Write-Host "   FFmpeg.AutoGen.Redist (optional)"
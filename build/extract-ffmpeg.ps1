#!/usr/bin/env pwsh
param(
    [Parameter(Mandatory=$true)]
    [string]$FFmpegTar,

    [string]$OutputPath = ".\FFmpeg"
)

$ErrorActionPreference = "Stop"

# Extract FFmpeg tar archive and prepare for code generation
# Usage: .\extract-ffmpeg.ps1 -FFmpegTar <ffmpeg_tar> [-OutputPath <output_path>]

if (-not $FFmpegTar) {
    Write-Host "❌ Usage: $($MyInvocation.MyCommand.Name) -FFmpegTar <ffmpeg_tar> [-OutputPath <output_path>]" -ForegroundColor Red
    exit 1
}

if (-not (Test-Path $FFmpegTar)) {
    Write-Host "❌ FFmpeg tar file not found: $FFmpegTar" -ForegroundColor Red
    exit 1
}

Write-Host "🔄 Extracting FFmpeg tar archive..." -ForegroundColor Blue

# Create output directory
if (Test-Path $OutputPath) {
    Remove-Item -Recurse -Force $OutputPath
}
New-Item -ItemType Directory -Path $OutputPath -Force | Out-Null

# Extract tar archive using Windows tar (available in Windows 10+) or 7-Zip
Write-Host "📦 Extracting $FFmpegTar to $OutputPath"

try {
    # Try Windows built-in tar first (Windows 10 1803+)
    if (Get-Command tar -ErrorAction SilentlyContinue) {
        & tar -xf $FFmpegTar -C $OutputPath --strip-components=1
        if ($LASTEXITCODE -ne 0) { throw "tar extraction failed" }
    }
    # Fallback to 7-Zip if available
    elseif (Get-Command 7z -ErrorAction SilentlyContinue) {
        # Extract to temp directory first, then move contents
        $tempDir = Join-Path $env:TEMP "ffmpeg_extract_$(Get-Random)"
        New-Item -ItemType Directory -Path $tempDir -Force | Out-Null
        & 7z x $FFmpegTar -o"$tempDir" -y
        if ($LASTEXITCODE -ne 0) { throw "7z extraction failed" }

        # Find the extracted directory and move its contents
        $extractedDir = Get-ChildItem -Path $tempDir -Directory | Select-Object -First 1
        if ($extractedDir) {
            Get-ChildItem -Path $extractedDir.FullName | Move-Item -Destination $OutputPath
        }
        Remove-Item -Recurse -Force $tempDir
    }
    # PowerShell 5.0+ with .NET compression
    else {
        Add-Type -AssemblyName System.IO.Compression.FileSystem

        # For .tar files, we need to handle this differently
        # This is a basic implementation - in production you might want to use a proper tar library
        throw "No suitable extraction tool found. Please install Windows 10 1803+ (with built-in tar) or 7-Zip"
    }
}
catch {
    Write-Host "❌ Extraction failed: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}

# Verify extraction
$RequiredDirs = @("bin", "include", "lib")
foreach ($dir in $RequiredDirs) {
    $fullPath = Join-Path $OutputPath $dir
    if (-not (Test-Path $fullPath)) {
        Write-Host "❌ Required directory '$dir' not found in extracted archive" -ForegroundColor Red
        exit 1
    }
}

Write-Host "✅ FFmpeg extraction completed successfully" -ForegroundColor Green
Write-Host "📂 Extracted to: $OutputPath"

# Show contents
Write-Host ""
Write-Host "📋 Extracted contents:" -ForegroundColor Blue
Get-ChildItem -Path $OutputPath -Directory | ForEach-Object {
    $count = (Get-ChildItem -Path $_.FullName -File -Recurse).Count
    Write-Host "   $($_.Name)/ ($count files)"
}
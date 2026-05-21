# One-shot move Bid + Onboarding -> BidOnboard (run from repo root: BidirectionalDomainCore)
$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $PSScriptRoot
Set-Location $root

New-Item -ItemType Directory -Path 'BidOnboard' -Force | Out-Null

function Move-Tree($source, $dest) {
    if (-not (Test-Path $source)) { return }
    $destParent = Split-Path $dest -Parent
    if ($destParent -and -not (Test-Path $destParent)) {
        New-Item -ItemType Directory -Path $destParent -Force | Out-Null
    }
    if (Test-Path $dest) {
        Get-ChildItem $source -Force | ForEach-Object {
            Move-Tree $_.FullName (Join-Path $dest $_.Name)
        }
        if ((Get-ChildItem $source -Force | Measure-Object).Count -eq 0) {
            Remove-Item $source -Force -Recurse -ErrorAction SilentlyContinue
        }
    } else {
        Move-Item -Path $source -Destination $dest -Force
    }
}

# --- Bid ---
Move-Tree 'Bid\Assessment' 'BidOnboard\Assessment'
Move-Tree 'Bid\Entities' 'BidOnboard\Entities'
Move-Tree 'Bid\Events' 'BidOnboard\Events'
Move-Tree 'Bid\Exceptions' 'BidOnboard\Exceptions'
Move-Tree 'Bid\Permission' 'BidOnboard\Permission'
Move-Tree 'Bid\ValueObjects' 'BidOnboard\ValueObjects'
Move-Tree 'Bid\Enum' 'BidOnboard\Enums'
Move-Tree 'Bid\Infrastructure' 'BidOnboard\Infrastructure\Bid'
Move-Tree 'Bid\Persistence' 'BidOnboard\Persistence'

if (Test-Path 'Bid\Application') {
    Move-Tree 'Bid\Application\Common' 'BidOnboard\Application\Common'
    if (Test-Path 'Bid\Application\Constants') {
        New-Item -ItemType Directory -Path 'BidOnboard\Application\Constants' -Force | Out-Null
        Move-Tree 'Bid\Application\Constants' 'BidOnboard\Application\Constants'
    }
}
if (Test-Path 'Bid\DependencyInjection') { Move-Tree 'Bid\DependencyInjection' 'BidOnboard\DependencyInjection' }

# --- Onboarding ---
Move-Tree 'Onboarding\Constants' 'BidOnboard\Constants'
Move-Tree 'Onboarding\Entities' 'BidOnboard\Entities'
if (Test-Path 'Onboarding\Enums') {
    $onbEnums = Get-ChildItem 'Onboarding\Enums' -File -ErrorAction SilentlyContinue
    foreach ($f in $onbEnums) {
        Move-Item $f.FullName (Join-Path 'BidOnboard\Enums' $f.Name) -Force
    }
}
Move-Tree 'Onboarding\Infrastructure' 'BidOnboard\Infrastructure\Onboarding'

if (Test-Path 'Onboarding\Application') {
    New-Item -ItemType Directory -Path 'BidOnboard\Application\Common' -Force | Out-Null
    if (Test-Path 'Onboarding\Application\Common\Interfaces') {
        Move-Tree 'Onboarding\Application\Common\Interfaces' 'BidOnboard\Application\Common\Interfaces'
    }
    if (Test-Path 'Onboarding\Application\Common\Models') {
        Move-Tree 'Onboarding\Application\Common\Models' 'BidOnboard\Application\Common\Models'
    }
}

# Remove empty Bid / Onboarding roots (keep placeholder folders from csproj if needed)
foreach ($dir in @('Bid', 'Onboarding')) {
    if (Test-Path $dir) {
        Get-ChildItem $dir -Recurse -Force | Remove-Item -Force -Recurse -ErrorAction SilentlyContinue
    }
}

Write-Host 'Move complete. BidOnboard file count:' (Get-ChildItem BidOnboard -Recurse -File).Count

$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $PSScriptRoot
Set-Location $root

function Update-File($path) {
    $content = [System.IO.File]::ReadAllText($path)
    $original = $content

    # Order matters: more specific first
    $content = $content.Replace('Bidirectional.DomainCore.Onboarding.Infrastructure.', 'Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.')
    $content = $content.Replace('Bidirectional.DomainCore.Bid.Infrastructure.', 'Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.')
    $content = $content.Replace('Bidirectional.DomainCore.Onboarding.', 'Bidirectional.DomainCore.BidOnboard.')
    $content = $content.Replace('Bidirectional.DomainCore.Bid.Enum', 'Bidirectional.DomainCore.BidOnboard.Enums')
    $content = $content.Replace('Bidirectional.DomainCore.Bid.', 'Bidirectional.DomainCore.BidOnboard.')

    if ($content -ne $original) {
        [System.IO.File]::WriteAllText($path, $content)
        return $true
    }
    return $false
}

$updated = 0
Get-ChildItem -Path $root -Recurse -Filter '*.cs' | Where-Object {
    $_.FullName -notmatch '\\obj\\' -and $_.FullName -notmatch '\\bin\\'
} | ForEach-Object {
    if (Update-File $_.FullName) { $script:updated++ }
}

Write-Host "Updated $updated files"

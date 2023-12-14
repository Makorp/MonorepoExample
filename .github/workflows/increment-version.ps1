param([string]$projectPath)

$xml = [xml](Get-Content $projectPath)
$version = $xml.Project.PropertyGroup.Version
$versionParts = $version.Split('.')
$versionParts[2] = [string]([int]$versionParts[2] + 1)
$newVersion = $versionParts -join '.'
$xml.Project.PropertyGroup.Version = $newVersion
$xml.Save($projectPath)

return $newVersion
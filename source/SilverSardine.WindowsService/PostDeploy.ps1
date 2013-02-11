$ServiceName = "SilverSardine"
$ServiceExecutable = "SilverSardine.WindowsService.exe"

$service = Get-Service $ServiceName -ErrorAction SilentlyContinue

$fullPath = Resolve-Path $ServiceExecutable

if (! $service)
{
    Write-Host "The service will be installed"
    
	New-Service -Name $ServiceName -BinaryPathName $fullPath -StartupType Automatic
}
else
{
    Write-Host "The service will be stopped and reconfigured"

    Stop-Service $ServiceName -Force
     
    & "sc.exe" config "$ServiceName" binPath= $fullPath start= auto | Write-Host
}

Write-Host "Starting the service"
Start-Service $ServiceName

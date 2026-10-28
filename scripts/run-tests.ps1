# Compila GeoLab2D y ejecuta las 18 pruebas de GeometryTests.RunAll() sin abrir la ventana.
# Uso (desde la raíz del repositorio, en Windows PowerShell 5.1):
#   powershell -ExecutionPolicy Bypass -File scripts\run-tests.ps1
# Requiere MSBuild (Visual Studio o Build Tools) con el paquete de destino de .NET Framework 4.7.2.

$ErrorActionPreference = 'Stop'
$raiz = Split-Path -Parent $PSScriptRoot
$proyecto = Join-Path $raiz 'GeoLab2D\GeoLab2D.csproj'

$msbuild = & "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" `
    -latest -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' | Select-Object -First 1
if (-not $msbuild) { throw 'No se encontró MSBuild. Instale Visual Studio o Build Tools.' }

& $msbuild $proyecto -nologo -v:m -p:Configuration=Debug
if ($LASTEXITCODE -ne 0) { throw 'La compilación falló.' }

$exe = Join-Path $raiz 'GeoLab2D\bin\Debug\GeoLab2D.exe'
$tipo = [Reflection.Assembly]::LoadFrom($exe).GetTypes() | Where-Object { $_.Name -eq 'GeometryTests' }
$resultados = $tipo.GetMethod('RunAll').Invoke($null, $null)

$resultados | Select-Object Prueba, Esperado, Obtenido, Estado | Format-Table -AutoSize
$aprobadas = @($resultados | Where-Object { $_.Estado -eq 'Aprobado' }).Count
Write-Host ("{0} de {1} pruebas aprobadas" -f $aprobadas, $resultados.Count)
if ($aprobadas -ne $resultados.Count) { exit 1 }

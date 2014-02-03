@ECHO OFF
SETLOCAL
SET VERSION=%1
SET NUGET=.\..\.nuget\nuget.exe

msbuild updateversionnumber.proj /p:AsmVersion=%VERSION%
msbuild /t:BuildRelease .\build.proj 
%NUGET% pack Mapsui.nuspec -Version %VERSION% -outputdirectory .\..\Release



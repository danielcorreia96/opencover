@echo off
set ChocolateyInstall=

SET VCTargetsPath=

build\nant-0.91-alpha2\bin\nant.exe -f:"%cd%"\default.build %1
if %ERRORLEVEL% == 0 goto :next

:quit
exit /b %ERRORLEVEL%

:next
@echo.
@echo %date%
@echo %time%
@echo.
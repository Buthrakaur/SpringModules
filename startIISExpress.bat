SET iisDir=%ProgramFiles%\IIS Express
pushd "%iisDir%" 2>NUL && popd
@if errorlevel 1 SET iisDir=%ProgramFiles(x86)%\IIS Express 

"%iisDir%\iisexpress.exe" /path:"%CD%\SampleWebFormsApp" /port:1777
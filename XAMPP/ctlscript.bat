@echo off
rem START or STOP Services
rem ----------------------------------
rem Check if argument is STOP or START

if not ""%1"" == ""START"" goto stop

if exist E:\coding\XAMPP\hypersonic\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\server\hsql-sample-database\scripts\ctl.bat START)
if exist E:\coding\XAMPP\ingres\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\ingres\scripts\ctl.bat START)
if exist E:\coding\XAMPP\mysql\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\mysql\scripts\ctl.bat START)
if exist E:\coding\XAMPP\postgresql\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\postgresql\scripts\ctl.bat START)
if exist E:\coding\XAMPP\apache\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\apache\scripts\ctl.bat START)
if exist E:\coding\XAMPP\openoffice\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\openoffice\scripts\ctl.bat START)
if exist E:\coding\XAMPP\apache-tomcat\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\apache-tomcat\scripts\ctl.bat START)
if exist E:\coding\XAMPP\resin\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\resin\scripts\ctl.bat START)
if exist E:\coding\XAMPP\jetty\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\jetty\scripts\ctl.bat START)
if exist E:\coding\XAMPP\subversion\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\subversion\scripts\ctl.bat START)
rem RUBY_APPLICATION_START
if exist E:\coding\XAMPP\lucene\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\lucene\scripts\ctl.bat START)
if exist E:\coding\XAMPP\third_application\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\third_application\scripts\ctl.bat START)
goto end

:stop
echo "Stopping services ..."
if exist E:\coding\XAMPP\third_application\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\third_application\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\lucene\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\lucene\scripts\ctl.bat STOP)
rem RUBY_APPLICATION_STOP
if exist E:\coding\XAMPP\subversion\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\subversion\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\jetty\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\jetty\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\hypersonic\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\server\hsql-sample-database\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\resin\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\resin\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\apache-tomcat\scripts\ctl.bat (start /MIN /B /WAIT E:\coding\XAMPP\apache-tomcat\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\openoffice\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\openoffice\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\apache\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\apache\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\ingres\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\ingres\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\mysql\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\mysql\scripts\ctl.bat STOP)
if exist E:\coding\XAMPP\postgresql\scripts\ctl.bat (start /MIN /B E:\coding\XAMPP\postgresql\scripts\ctl.bat STOP)

:end


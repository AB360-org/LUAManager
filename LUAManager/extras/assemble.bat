@echo off
set inputfile = %2
set outputfile = %3
cd extras
java.exe -jar unluac_assemble.jar --assemble %2 --output %3
::Hi PigDoggo, I fixed the folder extraction thing that was bugging you
@echo off
set inputfile = %2
set outputfile = %3
cd extras
java.exe -jar unluac.jar %2 > %3

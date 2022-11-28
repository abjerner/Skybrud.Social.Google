@echo off
dotnet build src/Skybrud.Social.Google --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:\nuget
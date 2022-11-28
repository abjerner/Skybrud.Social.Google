@echo off
dotnet build src/Skybrud.Social.Google --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget
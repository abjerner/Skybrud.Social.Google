# Skybrud.Social.Google [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md) [![NuGet](https://img.shields.io/nuget/v/Skybrud.Social.Google.svg)](https://www.nuget.org/packages/Skybrud.Social.Google) [![NuGet](https://img.shields.io/nuget/dt/Skybrud.Social.Google.svg)](https://www.nuget.org/packages/SSkybrud.Social.Google)

*Skybrud.Social.Google* is an authentication and service implementation for the Google API - targeting both .NET Framework and .NET Standard.

### Installation

You can download this package from either NuGet (recommended) or download a ZIP file with the neccessary files from here on GitHub:

1. [**NuGet Package**][NuGetPackage]  
Install this NuGet package in your Visual Studio project. Makes updating easy.

2. [**ZIP file**][GitHubRelease]  
Grab a ZIP file of the latest release; unzip and move the files to the bin directory of your project.

### Google APIs

*Skybrud.Social.Google* primarily handles authentication with the Google API, and also serves as a base implementation for the the long list of underlying APIs.

Through individual packages (building on top of *Skybrud.Social.Google*), I've also implemented packages for the following APIs:

- [**Analytics**](https://github.com/abjerner/Skybrud.Social.Google.Analytics)
- [**Geocoding**](https://github.com/abjerner/Skybrud.Social.Google.Geocoding)
- [**Places**](https://github.com/abjerner/Skybrud.Social.Google.Places)
- [**YouTube**](https://github.com/abjerner/Skybrud.Social.Google.YouTube)

### Found a bug? Have a question?

* Please feel free to [**create an issue**][Issues], and I will get back to you ;)

### Changelog

The [**releases page**][Releases] lists all releases, and each there will be some information for each release on the most significant changes.

### Documentation

You can find documentation and examples on how to use this package at the [**Skybrud.Social website**][Website]. The package isn't yet fully documented, so feel free to [**create an issue**][Issues] if I've missed something.

[Website]: http://social.skybrud.dk/google/
[NuGetPackage]: https://www.nuget.org/packages/Skybrud.Social.Google
[GitHubRelease]: https://github.com/abjerner/Skybrud.Social.Google/releases/latest
[Releases]: https://github.com/abjerner/Skybrud.Social.Google/releases
[Issues]: https://github.com/abjerner/Skybrud.Social.Google/issues

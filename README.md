# C# 10 and .NET 6 

Notes on C# and .NET from "C# 10 and .NET 6" textbook by Mark J. Price

### Getting Started
* [Downloading Microsoft Visual Studio 2022 for Windows](#01)
### Notes and Projects
* [Ch1 - Building Console Apps](Chapter1.md)
* [Ch2 - The C# Language](Chapter2.md)
* [Key Definitions](#Keywords.md)

---
<a name="01"></a>
### Getting Started Quickly

If you want to just mess around with code staight away without downloading software, then use this link: https://dotnetfiddle.net/.

### Downloading Microsoft Visual Studio 2022 for Windows

In the notes and projects, I use Microsoft Visual Studio 2022:

1. Download Microsoft Visual Studio 2022 version 17.0 or later for Windows from the following link: [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/).

2. Once the installer has launched, select the following **Workloads**:
	* ASP.NET and Web Development
	* Azure development
	* .NET desktop development
	* Desktop development with C++
	* Universal Windows Platform development
	* Mobile development with .NET

*You may have to access the Workloads through the "Visual Studio Installer" > Installed tab > Modify button on Visual Studio Community 2022 card.*

3. On the **Individual components** tab, in the **Code tools** section select the following:
	* Class Designer
	* Git for Windows
	* PreEmptive Protection - Dotfuscator

4. Click Install, then Launch.

### (Optional) Downloading Visual Studio Code Instead
This part is not necessary if you are going to just use Visual Studio 2022 to follow this guide. However, if you prefer to use Visual Studio Code to follow along then please install the extensions in steps 2-5 below:

1. Download and install either the Stable build of Visual Studio
Code from the following link: https://code.visualstudio.com/.
2. Download and install the .NET SDKs for versions 3.1, 5.0, and 6.0 from the following
link: https://www.microsoft.com/net/download.
3. Launch Visual Studio Code, got the **Extensions** tab and intall the 
C# extension.
3. Search for .NET Interactive Notebooks extension - download and install.

---
<a name="0x"></a>


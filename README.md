# C# 10 and .NET 6 

Notes on C# and .NET from "C# 10 and .NET 6" textbook by Mark J. Price

### Contents
* [00 Prerequisites](#00)
* [01 Downloading Microsoft Visual Studio 2022 for Windows](#01)
* [02 Downloading Visual Studio Code](#02)
*
* [0x Key Definitions](#0x)
---
<a name="00"></a>
### 00 Prerequisites


The tutorial uses the following software and tools:
* Visual Studio 2022 (Installation guide below)
* Visual Studio Code for Windows

---
<a name="01"></a>
### 01 Downloading Microsoft Visual Studio 2022 for Windows


1. Download Microsoft Visual Studio 2022 version 17.0 or later for Windows from the following link: [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/).

2. Once the installer has launched, select the following **Workloads**:
	* ASP.NET and Web Development
	* Azure development
	* .NET desktop development
	* Desktop development with C++
	* Universal Windows Platform development
	* Mobile development with .NET

*You may have to access the Workloads through the "Visual Studio Installer" > Installed tab > Modify button on Visual Studio Community 2022 card.*

3. On the **Indivdual components** tab, in the **Code tools** section select the following:
	* Class Designer
	* Git for Windows
	* PreEmptive Protection - Dotfuscator

4. Click Install, then Launch.

<a name="02"></a>
### 02 Downloading Visual Studio Code 

1. Download and install either the Stable build of Visual Studio
Code from the following link: https://code.visualstudio.com/.
2. Download and install the .NET SDKs for versions 3.1, 5.0, and 6.0 from the following
link: https://www.microsoft.com/net/download.
3. Launch Visual Studio Code, got the **Extensions** tab and intall the 
C# extension.
3. Search for .NET Interactive Notebooks extension - download and install.

---
### 0x Key Definitions
<a name="0x"></a>
* **.NET :** A development framework used to build cross-platform applications using web, mobile and desktop apps using C#. 

* The .NET was initially named ".NET Framework", and although the intention was to build a cross-platform framework, the framework heavily supported Windows applications. A more convincing cross-platform framework was developed as the ".NET Core" in 2015. It is now simply called ".NET" (2021) and is truly cross-platform supporting macOS and mobile applications. *

* **Namespace :** A declarative region that provides a scope to the 
identifiers inside it (the names of types, functions, variables, etc.).
* **Identifers :** Variable or object name
* **Long Term Support releases :** LTS applications are stable and have fewer updates, hence it is a better choice for applications that you do not intend to update frequently.
* **Current releases :** These releases are continuously improved based on feedback, and therefore this is a good choice if you are actively devlopping, as your application would be optimised with the latest improvements. However, if your project is not updated and maintained, features may not be supported anymore.

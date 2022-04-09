# C# 10 and .NET 6 

Notes on C# and .NET from "C# 10 and .NET 6" textbook by Mark J. Price

### Contents
* [00 - Prerequisites](#00)
* [01 - Downloading Microsoft Visual Studio 2022 for Windows](#01)
* [02 - Downloading Visual Studio Code](#02)
*
* [0x - Key Definitions](#0x)
---
<a name="00"></a>
### 00 - Prerequisites

The tutorial uses the following software and tools:
* Visual Studio 2022 (Installation guide below)

---
<a name="01"></a>
### 01 - Downloading Microsoft Visual Studio 2022 for Windows

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

### 02 - Downloading Visual Studio Code (Optional)
This part is not necessary if you are going to just use Visual Studio 2022 to follow this guide. However, if you prefer to use Visual Studio to follow along then please install the extensions in steps 2-5 below:

1. Download and install either the Stable build of Visual Studio
Code from the following link: https://code.visualstudio.com/.
2. Download and install the .NET SDKs for versions 3.1, 5.0, and 6.0 from the following
link: https://www.microsoft.com/net/download.
3. Launch Visual Studio Code, got the **Extensions** tab and intall the 
C# extension.
3. Search for .NET Interactive Notebooks extension - download and install.

---
<a name="02"></a>
### 03 - Building Console Apps






















---
<a name="0x"></a>
### 0x - Key Definitions

* **.NET :** A development framework used to build cross-platform applications using web, mobile and desktop apps using C#. 

*The .NET was initially named ".NET Framework", and although the intention was to build a cross-platform framework, the framework heavily supported Windows applications. A more convincing cross-platform framework was developed as the ".NET Core" in 2015. It is now simply called ".NET" (2021) and is truly cross-platform supporting macOS and mobile applications.*

* **Namespace :** A declarative region that provides a scope to the 
identifiers inside it (the names of types, functions, variables, etc.).
* **Identifers :** Variable or object name
* **Long Term Support releases :** LTS applications are stable and have fewer updates, hence it is a better choice for applications that you do not intend to update frequently.
* **Current releases :** These releases are continuously improved based on feedback, and therefore this is a good choice if you are actively devlopping, as your application would be optimised with the latest improvements. However, if your project is not updated and maintained, features may not be supported anymore.
* **Roslyn :** This is the C# compiler used by dotnet CLI tool, which converts C# source code to IL (intermdeiate language) code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by CoreCLR (.NET's virtual machine). At runtime, CoreCLR loads IL code from the assembly just-in-time compiler compiles to CPU instructions and executed.
<br>
c# -> IL -> processed by CLR just-in-time -> Native Machine Code

* **Assembly (in .NET) :** 
Assemblies are compiled code library used for deployment, versioning and security. Assemblies take the form of .exe or .dll files and are the building blocks of .NET applications. They provide a Common Language Runtime (CLR).
<br>
At the compilation stage MicroSoft can provide CLRs for Linux and macOS. This means at the second compilation stage would read a common IL (using CLR) to generate code for the native OS and CPU instruction set.
<br>
c# -> IL -> processed by CLR just-in-time -> Native Machine Code


<details>
<summary>How do I dropdown?</summary>
<br>
This is how you dropdown.
</details>
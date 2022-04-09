# C# 10 and .NET 6 

Notes on C# and .NET from "C# 10 and .NET 6" textbook by Mark J. Price

### Contents
* [00 - Prerequisites](#00)
* [01 - Downloading Microsoft Visual Studio 2022 for Windows](#01)
* [02 - Building Console Apps (Book Chapter 1)](#02)
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
<a name="02"></a>
### 02 - Building Console Apps (Book Chapter 1)

#### Printing "Hello, C\#"  
1. Create a **new project** using a **Console Application**
2. Name your project (e.g. "HelloCS") and choose a location. Solutions allow you to create and manage multiple projects - for "Solution name" you can put Chapter01 (or Project01)
3. Pick framework .NET 5.0 (we will use the older version for now). If it is not available in the drop down menu follow the instructions below:

 	> Visual Studio Installer (through Windows start menu) > MS Visual Studio 2022 > Modify > Individual Components > Tick .NET 5.0 Runtime > Restart Visual Studio and go to step 1.

 4. Modify the relevant line to print "Hello, C#!"
 5. Run the code by going to "Debug" > "Start without Debugging"

#### Top-level Programming 
We can condense the template code from: 
```C#
using System;

namespace HelloCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");
        }
    }
}

```
to this:
```C#
using System;
Console.WriteLine("Hello World!");
```
Why does this work?

* During compilation: the boilerplate code to define a *namespace*, *Program class*, and its *Main method* is generated and wrapped around the statement above.

What are the drawbacks?

* You can only have one file like this.
* Only works for C# 9 or later.
* "Using" still has to be at the top.

#### Adding new project
1. Navigate to File > Add > New Project
2. Save file to same solution "Chapter01" as ``TopLevelProgram``
3. You can have different .NET framework versions in the same project (i.e. .NET 6.0)
4. Press ``Program.cs`` in the *Solutions Explorer* to see the Source Code file(.cs).
5. You may have noticed the ``Program.cs`` for ``TopLevelProgram`` does not have *namespace, Main method* or *Program class*. But if this is in the format of top-level program where is the *Using* keyword? (see section below)

#### Implicitly imported namespaces
The reason the *Using* keyword is not necessary for the specific namespace ``System`` is because it is automatically imported as a global import.
<br><br>
This can be seen by, making the pressing the *Show All Files* button in *Solution Explorer* and then go down this directory:
> TopLevelProgram > obj > Debug > net6.0 > TopLevelProgram.GlobalUsings.g.cs
<br>
If you open the file `` TopLevelProgram.GlobalUsings.g.cs `` you will see all the global imports. 

#### Running the new project

Let's change some settings to easily run new projects:

> *Solution Explorer* > right-click *Chapter01 solution* > select *Set Startup Projects* > change to *Current selection* > Press OK.

Now simply press on the desired project ``TopLevelProgram`` and then navigate to:

> *Debug* (top ribbon) > *Start Without Debugging*
















---
<a name="0x"></a>
### 0x - Key Definitions

#### .NET 
* **.NET :** A development framework used to build cross-platform applications using web, mobile and desktop apps using C#. 

*The .NET was initially named ".NET Framework", and although the intention was to build a cross-platform framework, the framework heavily supported Windows applications. A more convincing cross-platform framework was developed as the ".NET Core" in 2015. It is now simply called ".NET" (2021) and is truly cross-platform supporting macOS and mobile applications.*

* **Namespace :** A declarative region that provides a scope to the 
identifiers inside it (the names of types, functions, variables, etc.).
* **Identifers :** Variable or object name
* **Long Term Support releases :** LTS applications are stable and have fewer updates, hence it is a better choice for applications that you do not intend to update frequently.
* **Current releases :** These releases are continuously improved based on feedback, and therefore this is a good choice if you are actively devlopping, as your application would be optimised with the latest improvements. However, if your project is not updated and maintained, features may not be supported anymore.
* **Roslyn :** This is the C# compiler used by dotnet CLI tool, which converts C# source code to IL (intermdeiate language) code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by CoreCLR (.NET's virtual machine). At runtime, CoreCLR loads IL code from the assembly just-in-time compiler compiles to CPU instructions and executed. Process: **c# -> IL -> processed by CLR just-in-time -> Native Machine Code**

* **Assembly (in .NET) :** 
Assemblies are compiled code library used for deployment, versioning and security. Assemblies take the form of .exe or .dll files and are the building blocks of .NET applications. They provide a Common Language Runtime (CLR). At the compilation stage MicroSoft can provide CLRs for Linux and macOS. This means at the second compilation stage would read a common IL (using CLR) to generate code for the native OS and CPU instruction set. Process: **c# -> IL -> processed by CLR just-in-time -> Native Machine Code**

#### OOPs and Keywords

* **Class :** A template definition of the methods and variables common to all objects of one type. E.g. the blueprint for a car.

* **Object :** An object is a particular instance of a class - it has a state (data) and behaviour (method). E.g. a particular car like VW Polo with your number plate.

* **Method :** An action the object can perform E.g. drive the car

* **Constructor :** This instantiates the object by forcing set default values. There can be many constructors. The constructor has no return type.

* **Instance Variables :** These are declared inside a class but outside the method, with an access modifier of "public". This is used to instantiate the object, with some attributes.

* **Access Modifiers :** These help implement "encapsulation" - i.e. information hiding. **Private** - only the current class will have access to the field or methods. **Public** - any class can rfer to the field or call the method. **Protected** - Only the current class and sub-classes have access to the field or methods.

* **Static :** This mean the method is associated with the class, and not a specific instance (object) of that class. Thus, you can call a static method without creating an instance of that class. Basically you use it as a function, without creating an object.

* **Void :** Mean there is no return value to this method

* **Scope :** Class scope defines the accessibility or visibility of class variables/functions.

* **Namespace :** These are used to organise classes. For example:
```C#
System.Console.WriteLine("Hello World!");
```
"System" is the namespace, "Console" is a class and "WriteLine" is a method.
You can also control the scope of your class using a namespace.
```C#
namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");
        }
    }
}
```
Namespace have implicitly public access and that is not modifiable.

* **Using :** The "using" keyword removes the need for the namespace to be used. For example:
```C#
using  System;
// The line below doesn't need to have "System" anymore
Console.WriteLine("Hello World!");
```


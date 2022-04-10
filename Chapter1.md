# Ch1 - Building Console Apps 
## Notes from Chapter 1 "C# 10 and .NET 6" by Mark J. Price
---
## Contents
Return [Home](README.md)
* [1.1 - Printing "Hello, C](#01.1)
* [1.2 - Top-level Programming](#01.2)
* [1.3 - Adding new project](#01.3)
* [1.4 - Implicitly imported namespaces](#01.4)
* [1.5 - Running the new project](#01.5)
* [1.6 - Question & Answer](#01.6)
---
<a name="02.1"></a>
### 1.1 - Printing "Hello, C\#"  
1. Create a **new project** using a **Console Application**
2. Name your project (e.g. "HelloCS") and choose a location. Solutions allow you to create and manage multiple projects - for "Solution name" you can put Chapter01 (or Project01)
3. Pick framework .NET 5.0 (we will use the older version for now). If it is not available in the drop down menu follow the instructions below:

 	> Visual Studio Installer (through Windows start menu) > MS Visual Studio 2022 > Modify > Individual Components > Tick .NET 5.0 Runtime > Restart Visual Studio and go to step 1.

 4. Modify the relevant line to print "Hello, C#!"
 5. Run the code by going to "Debug" > "Start without Debugging"

---
<a name="02.2"></a>
### 1.2 - Top-level Programming 
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

---
<a name="01.3"></a>
### 1.3 - Adding new project
1. Navigate to File > Add > New Project
2. Save file to same solution "Chapter01" as ``TopLevelProgram``
3. You can have different .NET framework versions in the same project (i.e. .NET 6.0)
4. Press ``Program.cs`` in the *Solutions Explorer* to see the Source Code file(.cs).
5. You may have noticed the ``Program.cs`` for ``TopLevelProgram`` does not have *namespace, Main method* or *Program class*. But if this is in the format of top-level program where is the *Using* keyword? (see section below)

---
<a name="01.4"></a>
### 1.4 - Implicitly imported namespaces
The reason the *Using* keyword is not necessary for the specific namespace ``System`` is because it is automatically imported as a global import.
<br><br>
This can be seen by, making the pressing the *Show All Files* button in *Solution Explorer* and then go down this directory:
> TopLevelProgram > obj > Debug > net6.0 > TopLevelProgram.GlobalUsings.g.cs
<br>
If you open the file *TopLevelProgram.GlobalUsings.g.cs* you will see all the global imports. 

---
<a name="01.5"></a>
### 1.5 - Running the new project

Let's change some settings to easily run new projects:

> *Solution Explorer* > right-click *Chapter01 solution* > select *Set Startup Projects* > change to *Current selection* > Press OK.

Now simply press on the desired project ``TopLevelProgram`` and then navigate to:

> *Debug* (top ribbon) > *Start Without Debugging*

---
<a name="01.6"></a>
### 1.6 - Question & Answer
<br>

<details>
<summary><b>1. Is Visual Studio 2022 better than Visual Studio Code?</b></summary>
<br>
No, depends on the task. Visual Studio 2022 is heavier but can create applications with GUI. VS Code is much lighter and code-focussed. 
<br><br></details>

<details>
<summary><b>2. Is .NET 6 better than .NET Framework?</b></summary>
<br>
Yes for modern development. .NET6 is cross-platform compatible and performance-oriented version of the legacy .NET Framework.
<br><br></details>

<details>
<summary><b>3. What is .NET Standard and why is it still important?</b></summary>
<br>
.NET Standard defines an API that a .NET platform can implement.
<br><br>
For example .NET framework, Xamarin and modern .NET implements ".NET Standards 2.0".
<br><br>
However, for .NET Core 3.0 there is a newer version ".NET Standards 2.1", which will have some features not supported by .NET Framework (legacy version). Therefore, if you will be doing parts of your project with the legacy version, then for you new class library to support all .NET platforms it needs to be ".NET Standards 2.0-compatible".
<br><br></details>

<details>
<summary><b>4. Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET?</b></summary>
<br>
C#, F# and Viual Baics languages are compiled to an Intermediate Language file (.exe or .dll) using different compilers (such as Roslyn for C#). IL is then compiled to native CPU instructions using CLR (common language runtime) at run-time.
<br><br></details>

<details>
<summary><b>5. What is the name of the entry point method of a .NET console application and how should it be declared?</b></summary>
<br>
Main method - it should be declared with void (since this method doesn't need to return anything). It should have an access mofifier of public, so that the compiler can find the method - for C# this is covered by the namespace keyword. The static keyword is used to associate the method to the class rather than an object (removes the need to instantiate an object to use the method). Optionally, we can have a string array as command-line arguments, and return int (rather than void).
<br><br>
Code: static void main(string[] args).
<br><br></details>

<details>
<summary><b>6. What is a top-level program and how do you access any command-line arguments?</b></summary>
<br>
A top-level-program is a project that does no explicitly need to mention namespace, program class and main method. These are implicitly defined for you to be able to type code without boiler-plate wrapper code.
<br><br>
To access command-line arguments in this case, you can use a parameter named "args"  - this is part of the behind the scene wrapper code for command-line arguments.
<br><br></details>

<details>
<summary><b>7. What do you type at the prompt to build and execute C# source code?</b></summary>
<br>
Within a folder which contains ".csproj file" you can enter "dotnet run".
<br><br></details>

<details>
<summary><b>8. What are some benefits of using .NET Interactive Notebooks to write C# code?</b></summary>
<br>
You can modularise the code, and see what the output would be for a function or script really easily. You can mix different languages in the same document. Also, can use markdown.
<br><br></details>

<details>
<summary><b>9. Where would you look for help for a C# keyword?</b></summary>
<br>
Microsoft's official C# documentation, or the "Go to definition" section in Visual Studio Code.
<br><br></details>

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
<summary>1. Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>2. Is .NET 6 better than .NET Framework?</summary>
<br>
Yes .NET6 is cross-platform compatible with a unified framework
</details>

<details>
<summary>3. What is .NET Standard and why is it still important?</summary>
<br>
.NET Standard is a specification which tells you which APIs are require for you version of .NET – essentially what will work and will not. This is important for legacy .NET frameworks to figure out the limits of their applications?
</details>

<details>
<summary>4. Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET?</summary>
<br>
C# and F# is compiled to an Intermediate Language file (.exe or .dll) using Roslyn the compiler– this can be run on any native computer using the CLR (common-language runtime)
<br><br></details>


<details>
<summary>5. What is the name of the entry point method of a .NET console application and how should it be declared?</summary>
<br>
Main method -
<br><br></details>

<details>
<summary>6. What is a top-level program and how do you access any command-line arguments?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>7. What do you type at the prompt to build and execute C# source code?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>8. What are some benefits of using .NET Interactive Notebooks to write C# code?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>9. Where would you look for help for a C# keyword?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>10. Where would you look for solutions to common programming problems?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>
# Ch1 - Building Console Apps 
## Notes from Chapter 1 from "C# 10 and .NET 6" by Mark J. Price
---
## Contents
Return [Home](README.md)
* [1.1 - Printing "Hello, C](#02.1)
* [1.2 - Top-level Programming](#02.2)
* [1.3 - Adding new project](#02.3)
* [1.4 - Implicitly imported namespaces](#02.4)
* [1.5 - Running the new project](#02.5)
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
<a name="02.3"></a>
### 1.3 - Adding new project
1. Navigate to File > Add > New Project
2. Save file to same solution "Chapter01" as ``TopLevelProgram``
3. You can have different .NET framework versions in the same project (i.e. .NET 6.0)
4. Press ``Program.cs`` in the *Solutions Explorer* to see the Source Code file(.cs).
5. You may have noticed the ``Program.cs`` for ``TopLevelProgram`` does not have *namespace, Main method* or *Program class*. But if this is in the format of top-level program where is the *Using* keyword? (see section below)

---
<a name="02.4"></a>
### 1.4 - Implicitly imported namespaces
The reason the *Using* keyword is not necessary for the specific namespace ``System`` is because it is automatically imported as a global import.
<br><br>
This can be seen by, making the pressing the *Show All Files* button in *Solution Explorer* and then go down this directory:
> TopLevelProgram > obj > Debug > net6.0 > TopLevelProgram.GlobalUsings.g.cs
<br>
If you open the file *TopLevelProgram.GlobalUsings.g.cs* you will see all the global imports. 

---
<a name="02.5"></a>
### 1.5 - Running the new project

Let's change some settings to easily run new projects:

> *Solution Explorer* > right-click *Chapter01 solution* > select *Set Startup Projects* > change to *Current selection* > Press OK.

Now simply press on the desired project ``TopLevelProgram`` and then navigate to:

> *Debug* (top ribbon) > *Start Without Debugging*

---
<a name="02.6"></a>
### 1.6 - Question & Answer
<br>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
</details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
</details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>


<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>

<details>
<summary>Is Visual Studio 2022 better than Visual Studio Code?</summary>
<br>
1.	No you can do everything in both, although Visual Studio 2022 is used by developers and in industry more often
<br><br></details>
# Ch2 - The C# Language
## Notes from Chapter 2 "C# 10 and .NET 6" by Mark J. Price
---
## Contents
Return [Home](README.md)
* [2.1 - .NET and C# Versions](#02.1)
* [2.2 - C# Vocabulary](#02.2)
* [2.6 - Question & Answer](#02.6)

The code for this tutorial can be found in ``code/Chapter02``

---



<a name="02.1"></a>
### 2.1 - .NET and C# Versions  
* You can find out the version of your .NET SDK (Software Development Kit) on Windows by typing the following into *Command Prompt*:
```
dotnet --version
```
* If you want to use features from a point release, that is, if your have C# 7.0 but want to use 7.1, 7.2, etc., you can modify the language version (``<LangVersion>``) in ``.csproj`` file, as follows:

```csproj
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net6.0</TargetFramework>
        <LangVersion>7.1</LangVersion>
    </PropertyGroup>
</Project>
```
---
<a name="02.2"></a>
### 2.2 - C\# Vocabulary
* **New project :** Create a new console app project:
    * Project name: *Vocabulary*
    * Location: ``...\code``
    * Solution name: *Chapter02*

    > Remember that the solution name puts the project into a nice package.
* **Compiler and Language Version :** Add ``#error version`` above the print line, and run code. This will show the version as an error (check Error List)

* **Compiler and Language Version :** Add ``#error version`` above the print line, and run code. This will show the version as an error (check Error List)

* **Using :** The ``using System;`` keyword points to the namespace for types. If the namespace hasn't been prefixed to the types as such: ``System.Console.Writeline("...")``, then the compiler looks for the "Using" keyword.
* **Types :** C# provides a standard set of built-in types. These represent integers, floating point values, Boolean expressions, text characters, decimal values, and other types of data. There are also built-in string and object types. You use the struct, class, interface, enum, and record constructs to create your own custom types.
* **Global namespaces :** You can set your own global namespaces which will be used accross your projects and classes as:
```C#
global using System;
global using System.Linq;
global using System.Collections.Generic;
```

    > Recommended to use a seperate C# file for just global imports named ``GlobalUsings.cs``













---
<a name="02.6"></a>
### 2.6 - Question & Answer
<br>

<details>
<summary><b>1. What does the .csproj file do?</b></summary>
<br>
This extension is a C# project file that contains the list of files included in a project along with the references to system assemblies (dependencies)
<br><br></details>

<details>
<summary><b>2. What do namespace, class and method mean?</b></summary>
<br>
A namespace contains types like classes to group them together.
<br><br>
A class contains the members of an object including methods.
<br><br>
A method contains statements that implement an action that an object can take.
<br><br></details>
# Ch3 - Controlling Flow, Converting Types, and Handling Exceptions
## Notes from Chapter 3 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [3.1 - .NET and C# Versions](#02.1)

* [3.14 - Question & Answer](#02.14)

The code for this tutorial can be found in ``code/Chapter03``

---

<a name="03.1"></a>
### 3.1 - .NET and C# Versions  
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
<a name="03.14"></a>
### 3.14 - Question & Answer
<br>

<details>
<summary><b>1. What does the .csproj file do?</b></summary>
<br>
This extension is a C# project file that contains the list of files included in a project along with the references to system assemblies (dependencies)
<br><br></details>


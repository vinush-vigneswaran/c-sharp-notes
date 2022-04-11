# Ch2 - The C# Language
## Notes from Chapter 2 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [2.1 - .NET and C# Versions](#02.1)
* [2.2 - C# Vocabulary](#02.2)
* [2.3 - Static Keyword](#02.3)
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

#### **New project** 
Create a new console app project:
* Project name: *Vocabulary*
* Location: ``...\code``
* Solution name: *Chapter02*

> Remember that the solution name puts the project into a nice package.
#### **Compiler and Language Version** 
* Add ``#error version`` above the print line, and run code. This will show the version as an error (check Error List)

#### **Using** 
* The ``using System;`` keyword points to the namespace for types. If the namespace hasn't been prefixed to the types as such: ``System.Console.Writeline("...")``, then the compiler looks for the "Using" keyword.

#### **Types** 
* C# provides a standard set of built-in types. These represent integers, floating point values, Boolean expressions, text characters, decimal values, and other types of data. There are also built-in string and object types. You use the struct, class, interface, enum, and record constructs to create your own custom types.

#### **Global namespaces** 
* You can set your own global namespaces which will be used accross your projects and classes as:
```C#
global using System;
global using System.Linq;
global using System.Collections.Generic;
```
* Recommended to use a seperate C# file for just global imports named *GlobalUsings.cs*. 

* The C#10 compiler automatically generates a .cs file for global imports in the *obj* folder. We can control these implicit imports by altering the ``.cdproj`` file:
    1. Go to *Solutions Explorer* > Select *Vocabulary Project* > *toggle Show All files* > select *obj* folder in the directory > *debug* > *net6.0*.
    2. Examine the ``Vocabulary.GlobalUsings.g.cs`` file. These are implictly imported global namespaces. 
    3. Let's change what namespaces are implicitly imported. Close the ``Vocabulary.GlobalUsings.g.cs`` file.
    4. We will remove the "System.Treading" namespaces and add "System.Numeric". Now press on *Vocabulary* project (.csproj) and add the following.
    ```
    <Project Sdk="Microsoft.NET.Sdk">
        <PropertyGroup>
            <OutputType>Exe</OutputType>
            <TargetFramework>net6.0</TargetFramework>
            <ImplicitUsings>enable</ImplicitUsings>
            <Nullable>enable</Nullable>
        </PropertyGroup>

        <ItemGroup>
            <Using Remove="System.Threading" />
            <Using Include="System.Numerics" />
        </ItemGroup>
    </Project>
    ``` 
    5. Save changes, check ``Vocabulary.GlobalUsings.g.cs`` file again to see if the changes have been applied. 

#### **Methods**
With methods, the same method can be used differently based on it's arguments or other things (covered in Ch 5.) that can affect it's action. This is called ``overloading`` - "overloading a method". In the following example, the same function is used with different arugments producing different actions with those arguments:
```C#
// outputs the current line terminator string
// by default, this is a carriage-return and line feed (same as pressing enter)
Console.WriteLine();

// outputs the greeting and the current line terminator string
Console.WriteLine("Hello Ahmed");

// outputs a formatted number and date and the current line terminator string
Console.WriteLine("Temperature on {0:D} is {1}°C.",
DateTime.Today, 23.4);
```





---
<a name="02.3"></a>
### 2.3 - Static Keyword

Read through the comments of the code to understand how the static keyword works:

```C#
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("This is main functIon");

        // Create an object to run funcitons
        Car myCar = new Car("Toyota", "Prius");
        
        // Now I can access a non-static function
        myCar.stopCar();
        
        // To access numWheels - I need to use my instantiated object
        Console.WriteLine(myCar.numWheel);
        
        // I cannot access the variable numWheels without instantiating an object
        // But I can access vehicleType (static) without instantiating an object
        Console.WriteLine(Car.vehicleType);
        // Console.WriteLine(Car.numWheel); => Compilation error
        
        // Similarly I can access the static method without 
        // using the object I created, directly from the class.
        Car.seeCar();
    }
}


public class Car
{   
    public int numWheel = 4;
    public static String vehicleType = "Only cars";
    
    public Car(String make, String model)
    {
        Console.WriteLine("This car is of make: "+ make + " and model: " + model);
    }
    internal void stopCar()
    {
        Console.WriteLine("This function stops the car");
    }
    internal static void seeCar()
    {
        Console.WriteLine("This method does not need Car object to be instantiated");
    }
}
```
The output:
```
This is main funciton
This car is of make: Toyota and model: Prius
This function stops the car
4
Only cars
This function does not need for a Car object to be instantiated (because of the static)
```



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

<details>
<summary><b>3. What is the access modifier for the class and Main method?</b></summary>
<br>
As with Java the class can be named anything - but it must have an access modifier which is "internal" or "public".
<br><br></details>

<details>
<summary><b>4. What does the access modifier "internal" do?</b></summary>
<br>
"internal" provides access to the type within the Assembly. The assembly is essentially a 
<br><br></details>
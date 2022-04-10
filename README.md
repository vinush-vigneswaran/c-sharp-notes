# C# 10 and .NET 6 

Notes on C# and .NET from "C# 10 and .NET 6" textbook by Mark J. Price

### Getting Started
* [Downloading Microsoft Visual Studio 2022 for Windows](#01)
* [Key Definitions](#0x)
### Notes and Projects
* [Ch1 - Building Console Apps](Chapter1.md)
* [Ch2 - The C# Language](Chapter2.md)

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
### Key Definitions

#### .NET 
* **.NET :** A development framework used to build cross-platform applications using web, mobile and desktop apps using C#. 

*The .NET was initially named ".NET Framework", and although the intention was to build a cross-platform framework, the framework heavily supported Windows applications. A more convincing cross-platform framework was developed as the ".NET Core" in 2015. It is now simply called ".NET" (2021) and is truly cross-platform supporting macOS and mobile applications.*

* **Namespace :** A declarative region that provides a scope to the 
identifiers inside it (the names of types, functions, variables, etc.).
* **Identifiers :** Variable or object name
* **Long Term Support releases :** LTS applications are stable and have fewer updates, hence it is a better choice for applications that you do not intend to update frequently.
* **Current releases :** These releases are continuously improved based on feedback, and therefore this is a good choice if you are actively developing, as your application would be optimised with the latest improvements. However, if your project is not updated and maintained, features may not be supported anymore.
* **Roslyn :** This is the C# compiler used by dotnet CLI tool, which converts C# source code to IL (intermediate language) code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by CoreCLR (.NET's virtual machine). At runtime, CoreCLR loads IL code from the assembly just-in-time compiler compiles to CPU instructions and executed. Process: **c# -> IL -> processed by CLR just-in-time -> Native Machine Code**

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

* **main(String args[]) :** The main method is the entry point for program.
``String args[]``  takes in a String as an argument when used in Java/C# command line. For example in Java:
```Java
public class Test {

public static void main(String[] args){

    for(String s : args){
	System.out.println(s);
    }
	
    }
}
```
Thus, this can be used in the CLI by:
```
$ javac Test.java 
$ java Test 1 2 3
1
2
3
$ java Test "Hello World" "Tom Hanks"
Hello World
Tom Hanks
```


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
* **Statically typed language :** Is when the variable types are known at compile time (Java, C, C++, Go). Although, other languages offer a form of *type inference* where the type system deduce the type of variables (OCalm, Haskell, Scala, Kotlin). The type-check is done at compilation.
<br><br>
If we run this (Go):
```Go
package main

import ("fmt"
)

func silly(a int) {
    if (a > 0) {
        fmt.Println("Hi")
    } else {
        fmt.Println("3" + 5)
    }
}

func main() {
    silly(2)
}
```
Then, we get the error:
```
invalid operation: "3" + 5 (mismatched types string and int)
```
This error is produced, even though the function argument only checks the if-statement (and not the else-statement). This is because the type-check is done at compilation, and it checks all the code for type mismatch.

* **Dynamically typed languages :** It is not required for the variable type to be specified (Perl, Ruby, Python, etc.). You can still provide type information - but this is not mandatory. 
<br><br>
Type-check is done at run-time (Python):
```Python
def silly(a):
    if a > 0:
        print 'Hi'
    else:
        print 5 + '3'
```
Therefore this line runs perfectly fine:
```
silly(2)
```
Error is only raised if a problematic line is run:
```
silly(-1)
```
Outputs:
```
TypeError: unsupported operand type(s) for +: 'int' and 'str'
```
So bugs can easily go unnoticed (compared to statically-typed) unless tested properly.


#### C# and Visual Studio Code -specific Tips

* **Go to definition :** This allows you to see the public definition of the type or member. For example you can look at the underlying code for ``int``. Declare an integer in the main class then:
> *Click inside ``int``* > right-click > *go to definitions*

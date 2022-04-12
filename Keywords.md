# Key Definitions

## Contents
Return [Home](README.md)
* [1 - .NET](#1)
* [2 - OOPs and Keywords](#2)
* [3 - C# and Visual Studio Code -specific Tips](#3)

<a name="1"></a>
# .NET 

## .NET 
 A development framework used to build cross-platform applications using web, mobile and desktop apps using C#. 

*The .NET was initially named ".NET Framework", and although the intention was to build a cross-platform framework, the framework heavily supported Windows applications. A more convincing cross-platform framework was developed as the ".NET Core" in 2015. It is now simply called ".NET" (2021) and is truly cross-platform supporting macOS and mobile applications.*

## Namespace 
 A declarative region that provides a scope to the 
identifiers inside it (the names of types, functions, variables, etc.).
## Identifiers 
 Variable or object name
## Long Term Support releases 
 LTS applications are stable and have fewer updates, hence it is a better choice for applications that you do not intend to update frequently.
## Current releases 
 These releases are continuously improved based on feedback, and therefore this is a good choice if you are actively developing, as your application would be optimised with the latest improvements. However, if your project is not updated and maintained, features may not be supported anymore.
## Roslyn 
 This is the C# compiler used by dotnet CLI tool, which converts C# source code to IL (intermediate language) code and stores the IL in an assembly (a DLL or EXE file). IL code statements are like assembly language instructions, which are executed by CoreCLR (.NET's virtual machine). At runtime, CoreCLR loads IL code from the assembly just-in-time compiler compiles to CPU instructions and executed. Process: **c# -> IL -> processed by CLR just-in-time -> Native Machine Code**

## Assembly (in .NET) 
 
Assemblies are compiled code library used for deployment, versioning and security. Assemblies take the form of .exe or .dll files and are the building blocks of .NET applications. They provide a Common Language Runtime (CLR). At the compilation stage MicroSoft can provide CLRs for Linux and macOS. This means at the second compilation stage would read a common IL (using CLR) to generate code for the native OS and CPU instruction set. Process: **c# -> IL -> processed by CLR just-in-time -> Native Machine Code**

<a name="2"></a>
# OOPs and Keywords

## Class 
 A template definition of the methods and variables common to all objects of one type. E.g. the blueprint for a car.

## Object 
 An object is a particular instance of a class - it has a state (data) and behaviour (method). E.g. a particular car like VW Polo with your number plate.

## Method 
 An action the object can perform E.g. drive the car

## Constructor 
 This instantiates the object by forcing set default values. There can be many constructors. The constructor has no return type.

## Instance Variables 
 These are declared inside a class but outside the method, with an access modifier of "public". This is used to instantiate the object, with some attributes.

## Access Modifiers 
 These help implement "encapsulation" - i.e. information hiding. **Private** - only the current class will have access to the field or methods. **Public** - any class can rfer to the field or call the method. **Protected** - Only the current class and sub-classes have access to the field or methods.

## Static 
 This mean the method is associated with the class, and not a specific instance (object) of that class. Thus, you can call a static method without creating an instance of that class. Basically you use it as a function, without creating an object.

## Void 
 Mean there is no return value to this method

## main(String args[]) 
 The main method is the entry point for program.
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


## Scope 
 Class scope defines the accessibility or visibility of class variables/functions.

## Namespace 
 These are used to organise classes. For example:
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

## Using 
 The "using" keyword removes the need for the namespace to be used. For example:
```C#
using  System;
// The line below doesn't need to have "System" anymore
Console.WriteLine("Hello World!");
```
## Statically typed language 
 Is when the variable types are known at compile time (Java, C, C++, Go). Although, other languages offer a form of *type inference* where the type system deduce the type of variables (OCalm, Haskell, Scala, Kotlin). The type-check is done at compilation.
<br><br>
If we run this (Go):
```Go
package main

import ("fmt")

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

## Dynamically typed languages 
 It is not required for the variable type to be specified (Perl, Ruby, Python, etc.). You can still provide type information - but this is not mandatory. 
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

## Declarative coding 
Declarative programming is when you write your code in such a way that it describes what you want to do, and not how you want to do it. It is left up to the compiler to figure out the how.
Examples of declarative programming languages are Prolog and SQL (DROP table, doesn't give the user to freedom to tell "how" to drop the table). In C# declarative coding is done using LINQ. Most query based languages are declarative.

## Overloading 
 Overloading refers to the ability to use a single identifier *(the user-defined name of a program element)* to define multiple methods of a class that differ in their input and output parameters.

For example, ``doTask()`` and ``doTask(object o)`` are overloaded functions. To call the latter, an object must be passed as a parameter, whereas the former does not require a parameter, and is called with an empty parameter field. 

Another example:
```C#
// C# program to demonstrate the function
// overloading by changing the Number
// of parameters
using System;
class GFG {
 
    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
 
    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
 
    // Main Method
    public static void Main(String[] args)
    {
 
        // Creating Object
        GFG ob = new GFG();
 
        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                          + "integer value : " + sum1);
 
        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                          + "integer value : " + sum2);
    }
}
```
Output:
```
sum of the two integer value : 3
sum of the three integer value : 6
```
<a name="3"></a>
# C# and Visual Studio Code -specific Tips

## Go to definition 
 This allows you to see the public definition of the type or member. For example you can look at the underlying code for ``int``. Declare an integer in the main class then:
> *Click inside ``int``* > right-click > *go to definitions*
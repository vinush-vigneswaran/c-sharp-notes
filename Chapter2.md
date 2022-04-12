# Ch2 - The C# Language
## Notes from Chapter 2 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [2.1 - .NET and C# Versions](#02.1)
* [2.2 - C# Vocabulary](#02.2)
* [2.3 - The "Static" Keyword](#02.3)
* [2.4 - Naming Convention](#02.4)
* [2.5 - Numbers vs Decimals Storage Size](#02.5)
* [2.6 - Special Types](#02.6)
* [2.7 - Local Variables](#02.7)
* [2.8 - Inferring Type of a Local Variable](#02.8)
* [2.9 - No More Repeating Type for Object Creation](#02.9)
* [2.10 - Default of a Value Type](#02.10)
* [2.11 - Storing in Arrays](#02.11)
* [2.15 - Question & Answer](#02.15)

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
* You can set your own global namespaces which will be used across your projects and classes as:
    ```C#
    global using System;
    global using System.Linq;
    global using System.Collections.Generic;
    ```
* Recommended to use a separate C# file for just global imports named *GlobalUsings.cs*. 

* The C#10 compiler automatically generates a .cs file for global imports in the *obj* folder. We can control these implicit imports by altering the ``.cdproj`` file:
    1. Go to *Solutions Explorer* > Select *Vocabulary Project* > *toggle Show All files* > select *obj* folder in the directory > *debug* > *net6.0*.
    2. Examine the ``Vocabulary.GlobalUsings.g.cs`` file. These are implicitly imported global namespaces. 
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
* With methods, the same method can be used differently based on it's arguments or other things (covered in Ch 5.) that can affect it's action. This is called ``overloading`` - "overloading a method". In the following example, the same function is used with different arguments producing different actions with those arguments:
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
#### **Literal Value**
* This is when a variable has a fixed value. For example:
    ```C#
    char letter = 'A'; // assigning literal characters
    char digit = '1';
    char symbol = '$';
    char userChoice = GetSomeKeystroke(); // assigning from a fictitious function

    ```
* A *literal* is any notation for representing a value within source code. Whereas, *identifiers* refer to value in memory.
These are examples of literals:
    ```
    "hey" (a string)
    false (a boolean)
    3.14 (a real number)
    [1,2,3] (a list of numbers)
    (x) => x*x (a function)
    /^1?$|^(11+?)\1+$/ (a regexp)
    ```
* Not literals:
    ```
    std::cout (an identifier)
    foo = 0; (a statement)
    1+2 (an expression)
    ```
* In code:
    ```C#
    string x = "This is a literal";
    int y = 2; // so is 2, but not y
    int z = y + 4; // y and z are not literals, but 4 is
    int a = 1 + 2; // 1 + 2 is not a literal (it is an expression), but 1 and 2 considered separately are literals
    ```
#### **Verbatim Literal String**
* Sometimes you may unintentionally use an escape character:
    ```C#
    string filePath = "C:\televisions\sony\bravia.txt";
    ```
* Here, the ``\t`` will be compiled as "tab". To avoid this, you can prefix the string with an @ sign:
    ```C#
    string filePath = @"C:\televisions\sony\bravia.txt";
    ```
* This is a verbatim literal string, and it disables escape characters.

#### **Interpolated string**
A literal string prefixed with $ to enable embedded formatted variables. Example:

```C#
double a = 0.1;
Console.WriteLine($"This is my value : {a}");
```
---
<a name="02.3"></a>
### 2.3 - The "Static" Keyword

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
<a name="02.4"></a>
### 2.4 - Naming Convention

* **Camel Case** for local variables and private fields: ``cost`` and ``orderDetail`` .
* **Title Case** for types, methods and other members: ``Cost`` and ``DateOfBirth``.
Example:
```C#
// let the heightInMetres variable become equal to the value 1.88
double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
```
---
<a name="02.5"></a>
### 2.5 - Numbers vs Decimals Storage Size

#### Size difference
* The operator ``sizeof()`` tells you the size, in bytes, that the type uses in memory:
```C#
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}." );
```
* Running the code above you will realise that a ``double`` variable can store bigger numbers than a decimal variable and yet only uses half the space in memory. Why?

* *Double* 
    * Uses 8 bytes(64 bits)
    * Much Larger range
    * Stores in base 2
    * Faster computation (executed by machine)

* *Decimal* 
    * Uses 16 bytes (128 bits)
    * Smaller range 
    * Stores in base 10 (stores the value as large integer and with a note to shift the decimal point to the left)
    * Precise value
    * Slower computation (executed in software)

* ``decimal`` is stored as an large int, so the 128 bits has one sign bit, and 127 bits to represent the integer value as well as the position of the decimal. From the code above we know the max value of a decimal is ``max_val=79,228,162,514,264,337,593,543,950,335`` which is equivalent to 2^95 + 2^94 + 2^93 ... 2^0, in other words 95-digit binary with all ones is equivalent to ``max_val``. This means the remaining 32 bits is used for the decimal placing, and possibly other stuff.

* On the otherhand, ``double`` has 62 bits, but with a much higher ``max_val=1.80E+308``. This is because it uses an exponent (as a scaling factor) - being able to store larger values BUT at the cost of precision. The double is stored as a ``floating point`` number which consists of a mantissa/ significand/coefficient and an exponent: ``(coefficient)*2^(exponent)``. Think of this as standard form in science.

> ![Floating Point Memory Allocation](media/floating_point.png)

* Let's have a look at the scaling that happens within a double-precision floating-point format according to the IEEE 754 standard. The first bit is a sign bit, then we have 11 bits to represent the exponent, and 52 bits to represent the coefficient.
    * The signed bit, s, is simply converted using: ``(-1)^s``
    * The exponent part, p, is converted to decimal using this formula: ``2^(p-1023)``, the max value of p is 2047 but the value 2047 is reserved (as infinity or NaN), therefore, the highest value of p is 2046.
    * The fraction part, F, is converted using binary as F = ``(f_0 * 2^-0) + (f_1 * 2^-1)  + (f_2 * 2^-2)  + ... (f_51 * 2^-51) `` where
    ``f_n`` is the n-index of the fraction part of the binary. ``f_1`` would be the value of the first position in the binary.
    * Finally but the values into this formula to convert to decimal: ``(-1)^s * 2^(p-1023) * F``

* This means the max value of 64-bit double should be ``max_val = (1) * 2^(1023) * 9007199254740991 = 8E+324``. As you can see this is considerably larger than the actual value ``max_val=1.80E+308``. There is a difference in the two values by a factor of ``2^(52)``. Which means that the max value is actually found by ``max_val = (1) * 2^(1023-52) * 9007199254740991 = 1.80E+308``. 
* I have no idea what those 52 bits in the exponent is used for - since it is not used to convert to base 10.


#### Precision vs Performance
* The code below gives an unexpected result:
```C#
double x = 0.1;
double y = 0.2;

if (x + y == 0.3)
{
    Console.WriteLine($"{x} + {y} equals {0.3}");
}
else
{
    Console.WriteLine($"{x} + {y} does NOT equal {0.3}");
}
```
Output:
```
0.1 + 0.2 does NOT equal 0.3
```
* The double type is not guaranteed to be accurate because some numbers like 0.1 
cannot literally be represented as floating-point values.
* Better to use double when accuracy and equality comparrison is not needed (you can still use it for > abnd <).
* Let's try the same code with decimals:
```C#
decimal c = 0.1M; // M suffix means a decimal literal value
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}
```
Output:
```
0.1 + 0.2 equals 0.3
```
* The reason for this is the way the type stores the value in memory (read the section above this).
---
<a name="02.6"></a>
### 2.6 - Special Types
#### Object Types
* This is a special type named ``object`` that can store any type of data. 
    ```C#
    object height = 1.88; // storing a double in an object
    object name = "Amir"; // storing a string in an object
    Console.WriteLine($"{name} is {height} metres tall.");
    int length1 = name.Length; // gives compile error!
    int length2 = ((string)name).Length; // cast to string first
    Console.WriteLine($"{name} has {length2} characters.");
    ```
* Avoid this where possible, leads to messy code and poor performance.
* A better alternative is ``generics`` (Ch 6.) - better performance.
#### Dynamic Types
* Another special type called ``dynamic`` - even worse performance than ``object`` but does not require a specific cast.

    ```C#
    // storing a string in a dynamic object
    // string has a Length property
    dynamic something = "Ahmed";
    // this compiles but would throw an exception at run-time
    // if you later store a data type that does not have a
    // property named Length
    Console.WriteLine($"Length is {something.Length}"); //this outputs "Length is 5"
    ```
* When using ``dynamic`` the compiler cannot check the type during build time, instead the CLR checks for its member at runtime and throws an exception if missing. This is not type-inference because the type is figured out during run-time.

---
<a name="02.7"></a>
### 2.7 - Declaring Local Variables
* Local variables are declared inside methods and only exist during *execution* of that method.
* Once the method returns, the memory allocated is released.
* Value types are released, but references types must wait for a garbage collection.
* Variables of **reference type** stores references of their data, whilst variables of **value types** store values of data.
    ```C#
    int population = 66_000_000; // 66 million in UK
    double weight = 1.88; // in kilograms
    
    ```
---
<a name="02.8"></a>
### 2.8 - Inferring Type of a Local Variable
* Although Java is a statically-typed programming language, it does allows for the type to be inferred by using the keyword ``var``.
* In this case the inference happens at compilation time.
* The compiler infers the type based on the value assigned:
    ```C#
    var population = 66_000_000; // 66 million in UK
    var weight = 1.88; // in kilograms
    var price = 4.99M; // in pounds sterling (M infers decimal)
    var fruit = "Apples"; // strings use double-quotes
    var letter = 'Z'; // chars use single-quotes
    var happy = true; // Booleans have value of true or false
    ```
* A literal value without a decimal is inferred as ``int``, unless you add the following suffix (see 2nd example in code above):
    ```
    L: infers long
    UL: infers ulong
    M: infers decimal
    D: infers double
    F: infers float
    ```
---
<a name="02.9"></a>
### 2.9 - No More Repeating Type for Object Creation
* C# 9 onwards there is a new syntax for instantiating objects known a **target-typed new**.
* You don't need to repeat the type after the ``new`` keyword:
```C#
class Person
{
public DateTime BirthDate;
}
Person kim = new();// instead of: Person kim = new Person()
kim.BirthDate = new(1967, 12, 26); // instead of: new DateTime(1967, 12, 26)
```
---
<a name="02.10"></a>
### 2.10 - Default of a Value Type
* Most of the primitive types except string are: **value types** (must have a value).
* You can check the default value of a type by:
    ```C#
    Console.WriteLine($"default(int) = {default(int)}");
    Console.WriteLine($"default(bool) = {default(bool)}");
    Console.WriteLine($"default(DateTime) = {default(DateTime)}");
    Console.WriteLine($"default(string) = {default(string)}");
    ```
    Output:
    ```
    default(int) = 0
    default(bool) = False
    default(DateTime) = 01/01/0001 00:00:00
    default(string) =
    ```
* We can reset the value to default as such:
    ```C#
    int number = 13;
    Console.WriteLine($"number has been set to: {number}");
    number = default;
    Console.WriteLine($"number has been reset to its default: {number}");
    ```
* ``string`` type is a **reference type**, meaning the ``string`` variable contains the memory address of the value, but not the value itself. This can have a value of ``null`` indicating it does not reference anything.

---
<a name="02.11"></a>
### 2.11 - Storing in Arrays
* Arrays are of fixed size at the time of memory allocation, therefore, you have to decide how many items you want before instantiating them.
* Arrays are good for temporary storage, but when working dynamically to add/remove items ``collections`` are better.
* Ways to store multiple values in string array:
    ```C#
    string[] names; // can reference any size array of strings
    // allocating memory for four strings in an array
    names = new string[4];
    // storing items at index positions
    names[0] = "Kate";
    names[1] = "Jack";
    names[2] = "Rebecca";
    names[3] = "Tom";
    // looping through the names
    for (int i = 0; i < names.Length; i++)
    {
        // output the item at index position i
        Console.WriteLine(names[i]);
    }
    ```
* More compact:
    ```C#
    string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };
    ```
* At least one item must be in the curly brackets when using ``new[]`` so that the compiler can infer type.















---
<a name="02.15"></a>
### 2.15 - Question & Answer
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
<summary><b>4. Is the keyword "String" a class, object or variable?</b></summary>
<br>
String is a class. We create a new String object when we assign it to a variable name and give it a value.
This is not the case with primitive data types.
<br><br></details>

<details>
<summary><b>5. Why is double type smaller in memory but larger in range of values than decimal?</b></summary>
<br>
--
<br><br></details>

<details>
<summary><b>6. What is floating point arithmetic?</b></summary>
<br>
---
<br><br></details>
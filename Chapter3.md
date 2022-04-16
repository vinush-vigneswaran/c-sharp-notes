# Ch3 - Controlling Flow, Converting Types, and Handling Exceptions
## Notes from Chapter 3 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [3.1 - Definitions and Concepts](#03.1)
* [3.2 - Post- and Pre- Incrementors](#03.2)
* [3.3 - Short-circuiting Boolean Operators](#03.3)
* [3.4 - Exploring Bitwise and Binary Shift Operators](#03.4)
* [3.5 - Pattern Matching with Switch Statements](#03.5)
* [3.6 - Switch Expressions using Lambda](#03.6)

* [3.14 - Question & Answer](#03.14)

The code for this tutorial can be found in ``code/Chapter03``

---
<a name="03.1"></a>
### 3.1 - Definitions and Concepts

#### **Binary operators** 
* When an operator (e.g. +, -,/,\*) works on two operands e.g. ``int resultOfAdding = x + y;``

#### **Unary operators** 
* When an operator works on one operand:
 ```C#
int postfixIncrement = x++;
int prefixIncrement = ++x;
Type theTypeOfAnInteger = typeof(int);
int howManyBytesInAnInteger = sizeof(int);
 ```
* Examples of unary operators include incrementors and retrieving a type or its size in bytes.
* The operand can be before or after the operator.

#### **Miscellaneous Operators** 
* ``nameof`` returns the short name (without the namespace) of a variable, type, or member as a string value, which is useful when outputting exception messages. So for ``a=3``, ``nameof(a)`` would output ``a``.
* ``sizeof`` returns the size in bytes of simple types, which is useful for determining the efficiency of data storage.
* **Member access operator :** the dot between a variable and its members ``age.ToString()``.
* **Invocation operator :** the round brackets at the end of a method ``age.ToString()``.

#### **Pattern Matching**
* In the following example we will see a way of checking the variable type is correct before performing operations. If not, it will produce an warning message:
    ```C#
    // add and remove the "" to change the behavior
    object o = "3";
    int j = 4;
    if (o is int i)
    {
        WriteLine($"{i} x {j} = {i * j}");
    }
    else
    {
        WriteLine("o is not an int so it cannot multiply!");
    }
    ``` 
* If the value stored in the variable named ``o`` is an ``int``, then the value is assigned to the local variable named ``i``, which can then be used inside the ``if statement``. 
* This is safer than using the variable named ``o`` because we know for sure that ``i`` is an ``int`` variable and not something else.

#### **Switch Statement**

* Switch statements are similar to if-statements, because the ``switch`` compares a single expression against a list of multiple case statements. 
* Example:
    ```C#
    int number = (new Random()).Next(1, 7);
    WriteLine($"My random number is {number}");

    switch (number)
    {
        case 1:
            WriteLine("One");
            break; // jumps to end of switch statement
        case 2:
            WriteLine("Two");
            goto case 1;
        case 3: // multiple case section
        case 4:
            WriteLine("Three or four");
            goto case 1;
        case 5:
            goto A_label;
            default:
            WriteLine("Default");
        break;
    } // end of switch statement

    WriteLine("After end of switch");
    A_label:
        WriteLine($"After A_label");
    ```
* See in case 5, it says ``go to A_label`` which means it will skip to the line ``A_label:`` and carry on from there.
* A label, e.g. ``A_label``, is denoted with a colon.




---
<a name="03.2"></a>
### 3.2 - Post- and Pre- Incrementors

* Look at the following code:
    ```C#
    int a = 3;
    int b = a++;
    WriteLine($"a is {a}, b is {b}");
    ```
* When ``a++`` is called it returns its current value **then** executes the operator (+1) - a.k.a **postfix operator**
* This means ``b`` would be equal to 3, and then ``a`` is incremented to 4.
* Hence, the output is: 
    ```
    a is 4, b is 3
    ```
* In the case below, the operator is before the operand, hence the operation is executed then assigned - a.k.a **prefix operator**
    ```C#
    int c = 3;
    int d = ++c; // increment c before assigning it
    WriteLine($"c is {c}, d is {d}");
    ```
* Ouput:
    ```
    c is 4, d is 4
    ```
---
<a name="03.3"></a>
### 3.3 - Short-circuiting Boolean Operators
* Boolean operators use the following: ``&`` (AND), ``|`` (OR) and ``^`` (XOR)
* For conditional logical operators you use two symbols ``&&`` and ``||`` a.k.a short-circuiting Boolean operators.
* Let's look at the example below:
    ```C#
    static bool DoStuff()
    {
        WriteLine("This function has been called.");
        return true;
    }

    bool a = true;
    bool b = false;

    WriteLine($"a & DoStuff() = {a & DoStuff()}");
    WriteLine($"b & DoStuff() = {b & DoStuff()}");
    WriteLine();
    WriteLine($"a && DoStuff() = {a && DoStuff()}");
    WriteLine($"b && DoStuff() = {b && DoStuff()}");
    ```
* The output:
    ```
    This function has been called.
    a & DoStuff() = True
    This function has been called.
    b & DoStuff() = False

    This function has been called.
    a && DoStuff() = True
    b && DoStuff() = False
    ```
* In the above code, the function was called for the first three statements, but not for the last one. This is because if ``b=False``, then the output will be False regardless of the boolean value of ``DoStuff()``. Therefore, it does not need read past the ``&&`` symbols, thus does not need to run the function ``DoStuff()``.

---
<a name="03.4"></a>
### 3.4 - Exploring Bitwise and Binary Shift Operators
* Bit operations are much faster than than traditional operators.
* You can do bit-by-bit operations:
    ```
    // Exploring bitwise and binary shift operators

    int a = 10; // 00001010
    int b = 6; // 00000110

    WriteLine($"a = {a}");
    WriteLine($"b = {b}");
    WriteLine($"a & b = {a & b}"); // 2-bit column only
    WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
    WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns
    ```
* ``a & b`` is the same as ``and`` operating each bit as:  ``00001010`` && ``00000110`` = 00000010 => 2
* ``a | b`` is the same as ``or`` operating each bit as:  ``00001010`` ||``00000110`` = 00001110 => 14
* You can do bit shifting to do faster calculations:
    ```C#
    // 01010000 left-shift a by three bit columns
    WriteLine($"a << 3 = {a << 3}");
    // multiply a by 8
    WriteLine($"a * 8 = {a * 8}");
    ```
* The 80 result is because the bits in it were shifted three columns to the left, so the 1-bits moved into the 64- and 16-bit columns and 64 + 16 = 80. This is the same as multiplying by 8, but CPUs can perform a bit-shift faster.
* We can convert integers to 8-bit binary string using this function:
    ```C#
    static string ToBinaryString(int value)
    {
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
    }
    ```

---
<a name="03.5"></a>
### 3.5 - Pattern Matching with Switch Statements
* Similar to pattern matching with if-else statements above, with switch statements we can do a similar check:
```C#
string path = @"C:/Users/VINUS/Documents/35_CSHARP/c-sharp-notes/code/Chapter03";
Write("Press R for read-only or W for writeable: ");

ConsoleKeyInfo key = ReadKey();
WriteLine();
Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(
    Path.Combine(path, "file.txt"),
    FileMode.OpenOrCreate,
    FileAccess.Read);
}
else
{
    s = File.Open(
    Path.Combine(path, "file.txt"),
    FileMode.OpenOrCreate,
    FileAccess.Write);
}

string message;

switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        // If s.CanWrite is true (i.e. it is a write-able file)
        // and it is of class FileStream
        // then use writeableFile as the local variable of type FileStream (Class).
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        // Otherwise, if it's a FileStream then 
        // it is a readOnlyFile
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        // If its a Memory stream then this is satisfied
        message = "The stream is a memory address.";
        break;
    default: 
        // This is always evaluated last despite its current position
        message = "The stream is some other type.";
        break;
    case null:
        // If its null then this is satisfied
        message = "The stream is null.";
        break;
```
#### Understanding the Code
* The variable ``s`` can be declared as any ``Stream`` i.e. ``FileStream`` or ``MemoryStream``.
* However, we use the stream ``s`` to open a file, which returns a ``FileStream``.
* The user has the choice to make this ``FileStream`` either Write-able or Read-able.
* Therefore, as the code is now, we can only statisfy case 1 and 2.
* To understand the syntax, read the comments below each case condition in the code above.
* The ``when`` keyword is used to perform more specific pattern matching; in the first case statement, ``s`` will only be a match if the stream is a ``FileStream`` and its ``CanWrite`` property is true.

#### Comments
* As you can see the matching doesn't have to be a literal (i.e. case 1, case "a", etc.) - we are able to match with conditions/patterns.
* The order of switch cases matters, because if a preceding case covers the condition of a succeeding case, then the succeeding case will be unreachable. 
* In the code above, if case 1 (``FileStream`` and ``CanWrite``) and case 2 (``FileStream``) were swapped, then case 1 will never be reached because case 2 will be evaluated first, and thus since all ``FileStream`` and ``Write`` will staisfy the first condition of is it a ``FileStream``, it will never satisfy the second condition.



---
<a name="03.6"></a>
### 3.6 - Switch Expressions using Lambda







---
<a name="03.14"></a>
### 3.14 - Question & Answer
<br>

<details>
<summary><b>1. ?</b></summary>
<br>
This extension is a C# project file that contains the list of files included in a project along with the references to system assemblies (dependencies)
<br><br></details>


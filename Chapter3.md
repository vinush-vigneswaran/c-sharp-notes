# Ch3 - Controlling Flow, Converting Types, and Handling Exceptions
## Notes from Chapter 3 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [3.1 - Definitions](#03.1)
* [3.2 - Unary and Binary Operators](#03.2)
* [3.3 - Short-circuiting Boolean Operators](#03.3)
*
* [3.14 - Question & Answer](#03.14)

The code for this tutorial can be found in ``code/Chapter03``

---
<a name="03.1"></a>
### 3.1 - Definitions

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






---
<a name="03.2"></a>
### 3.2 - Unary and Binary Operators

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
    c is 4, b is 4
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
* In the above code, the function was called for the first three statements, but not for the last one. This is because if ``b=False``, then the output will be Fales regardless of the boolean value of ``DoStuff()``. Therefore, it does not need read past the ``&&`` symbols, thus does not need to run the function ``DoStuff()``.

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
<a name="03.14"></a>
### 3.14 - Question & Answer
<br>

<details>
<summary><b>1. ?</b></summary>
<br>
This extension is a C# project file that contains the list of files included in a project along with the references to system assemblies (dependencies)
<br><br></details>


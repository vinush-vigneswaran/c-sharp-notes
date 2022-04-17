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
* [3.7 - How does a For-each Loop Work?](#03.7)
* [3.8 - Casting Numbers (Implicitly and Explicitly)](#03.8)
* [3.9 - Converting to\\from String](#03.9)
* [3.10 - Handling Exceptions](#03.10)
* [3.11 - Question & Answer](#03.11)

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
* Output:
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
* Therefore, as the code is now, we can only satisfy case 1 and 2.
* To understand the syntax, read the comments below each case condition in the code above.
* The ``when`` keyword is used to perform more specific pattern matching; in the first case statement, ``s`` will only be a match if the stream is a ``FileStream`` and its ``CanWrite`` property is true.

#### Comments
* As you can see the matching doesn't have to be a literal (i.e. case 1, case "a", etc.) - we are able to match with conditions/patterns.
* The order of switch cases matters, because if a preceding case covers the condition of a succeeding case, then the succeeding case will be unreachable. 
* In the code above, if case 1 (``FileStream`` and ``CanWrite``) and case 2 (``FileStream``) were swapped, then case 1 will never be reached because case 2 will be evaluated first, and thus since all ``FileStream`` and ``Write`` will staisfy the first condition of is it a ``FileStream``, it will never satisfy the second condition.



---
<a name="03.6"></a>
### 3.6 - Switch Expressions using Lambda
* Switch expressions simplify the code using lambda ``=>`` to indicate return a value.

    ```C#

    message = s switch
    {
        FileStream writeableFile when s.CanWrite
            => "The stream is a file that I can write to.",
        FileStream readOnlyFile
            => "The stream is a read-only file.",
        MemoryStream ms
            => "The stream is a memory address.",
        null
            => "The stream is null.",
        _
            => "The stream is some other type."
    };
    WriteLine(message);

    ```
#### Main Differences
* Removal of ``case`` and ``break``
* The ``_`` is used instead of default.
* We return the string, and assign that to message. Rather than return ``message="..."`` at each case.

---
<a name="03.7"></a>
### 3.7 - How does a For-each Loop Work?
* A for-each loop iterates through a sequence (e.g. array or collection).
* Each item is read-only and if the items or the sequence is changed during the for-loop and exception will be thrown.
* If you wanted to create a type that can be iterated through using for-each, the following is a must:
    * The type must have a method named ``GetEnumerator`` that returns an object.
    * The returned object must have a property named ``Current`` and a method named ``MoveNext``.
    * The ``MoveNext`` method must change the value of ``Current`` and return ``true`` if there are more items to enumerate through or return ``false`` if there are no more items.
* The compiler turns the ``for each`` statement into this pseudo-code:
    ```C#
    IEnumerator e = names.GetEnumerator();
    // GetEnumerator() - Returns an enumerator that iterates through a collection.

    while (e.MoveNext())
    {
        string name = (string)e.Current; // Current is read-only!
        WriteLine($"{name} has {name.Length} characters.");
    }
    ```

---
<a name="03.8"></a>
### 3.8 - Casting Numbers (Implicitly and Explicitly)
* Implicit casting happens automatically, and it is safe, meaning that you will not lose any information.
* Explicit casting has to be implemented manually - because it may lose information. 


* Implicitly casting ``int`` to ``double`` is safe - no information is lost:
    ```C#
    int a = 10;
    double b = a; // an int can be safely cast into a double
    WriteLine(b);
    ```
* However, in the following case the compiler gives an error:
    ```C#
    double c = 9.8;
    int d = c; // compiler gives an error for this line
    WriteLine(d);
    ```
* The error:
    ```
    Error   CS0266  Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
    ```
* This is because this could be potentially "unsafe" - lose data
* In this case, we need to explicitly cast:
    ```C#
    int d = (int)c;
    WriteLine(d); // d is 9 losing the .8 part
    ```
* The cast chops off everything after the decimal (does not round).
* You may get weird results when casting explicitly, because some information is lost during the casting. For example from ``long`` to ``int``:
    ```C#
    long e = 10;
    int f = (int)e;
    WriteLine($"e is {e:N0} and f is {f:N0}");
    e = long.MaxValue;
    f = (int)e;
    WriteLine($"e is {e:N0} and f is {f:N0}");
    ```
* Returns the following:
    ```
    e is 10 and f is 10
    e is 9,223,372,036,854,775,807 and f is -1
    ```
* You can also change types using ``System.Convert`` type:
    ```C#
    double g = 9.8;
    int h = ToInt32(g); // a method of System.Convert
    WriteLine($"g is {g} and h is {h}");
    ```
* Output:
    ```
    g is 9.8 and h is 10
    ```
* Converting rounds the ``double`` value 9.8 up to 10 instead of chopping off after decimal, as with casting.


---
<a name="03.9"></a>
### 3.9 - Converting to\from String
* ``ToString`` converts to string. If the type cannot be represented as a string it returns the namespace and type name instead:
    ```C#
    int number = 12;
    WriteLine(number.ToString());

    bool boolean = true;
    WriteLine(boolean.ToString());

    DateTime now = DateTime.Now;
    WriteLine(now.ToString());

    object me = new();
    WriteLine(me.ToString());
    ```
* This is converted to:
    ```C#
    12
    True
    16/04/2022 17:33:54
    System.Object
    ```
* You can convert from binary object (e.g. bytes)  to Base64 encoding using ``ToBase64String`` and ``FromBase64String``. This encoding is useful when sending image or video by network protocol.
* The opposite of ``ToString`` is ``Parse``:
    ```C#
    int age = int.Parse("27");
    DateTime birthday = DateTime.Parse("4 July 1980");
    WriteLine($"I was born {age} years ago.");
    WriteLine($"My birthday is {birthday}.");
    WriteLine($"My birthday is {birthday:D}.");
    ```

---
<a name="03.10"></a>
### 3.10 - Handling Exceptions

* In order to handle exceptions where you know a statement can cause an error, use ``try-catch`` blocks.
* If any statement in the ``try`` block throws an exception, then the ``catch`` block will be executed.
* E.g. when parsing from string to int:
    ```C#
    WriteLine("Before parsing");
    Write("What is your age? ");
    string? input = ReadLine(); // or use "49" in a notebook
    try
    {
        int age = int.Parse(input);
        WriteLine($"You are {age} years old.");
    }
    catch
    {
        WriteLine("I was unable to parse that!");
    }
    WriteLine("After parsing");
    ```
* Although, this is not best practice, since the error message is just swallowed. You would want to throw or log any error messages.
* A more useful ``catch`` statement would be:
    ```C#
    catch (Exception ex)
    {
        WriteLine($"{ex.GetType()} says {ex.Message}");
    }
    ```
* Output:
    ```
    Before parsing
    What is your age? Jeremy
    System.FormatException says Input string was not in a correct format.
    After parsing
    ```
* You can also catch specific exceptions, e.g. ``System.FormatException``:
    ```C#
    catch (FormatException)
    {
        WriteLine("The age you entered is not a valid number format.");
    }
    catch (Exception ex)
    {
        WriteLine($"{ex.GetType()} says {ex.Message}");
    }
    ```
* Output:
    ```
    Before parsing
    What is your age? Kermit
    The age you entered is not a valid number format.
    After parsing
    ```

* The above code, will still catch other exceptions with the general catch condition.

---
<a name="03.11"></a>
### 3.11 - Question & Answer
<br>

<details>
<summary><b>

1. What is the difference between a while loop and a do-while loop?</b></summary>
<br>
The while loop checks the condition then runs the statement, whereas the do-while loop, runs the statement first then check if the condition is still true.
<br><br></details>


<details>
<summary><b>

2. What does a for-each loop do?</b></summary>

* It will iterate through an array/collection (sequences) - but the items are read-only

```C#
string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
WriteLine($"{name} has {name.Length} characters.");
}
```
<br><br></details>


<details>
<summary><b>

3. What is the default rounding rules when casting explicitly or converting between types?</b></summary>

* Rounding follows Banker's rule i.e. if the whole number is even then round down, otherwise round up. This reduces bias by alternating round up and down at .5
<br><br></details>

<details>
<summary><b>

4. How can you specify the type of rounding you want?</b></summary>

* Using the Math class, and specifying the mode e.g. ``MidpointRounding.AwayFromZero``.

<br><br></details>

<details>
<summary><b>

5. How does an exception handling work?</b></summary>

* An exception is an event, which occurs during the execution of a program, that disrupts the normal flow of the program's instructions.
* **Throwing an exception :** this is when there is an error in the method. The method (has a default setting) which creates an object (called an exception object) and "throws" it to the runtime system. 
* **Exception handling :** The runtime system goes back through the call stack, looking for a method that contains a block of code that can handle the exception (try-catch statement).
* **Catch the exception:** A chosen exception handler will "catch the exception", and act accordingly.
* If there are no code that catches the exception, then the runtime system terminates, and outputs the error and stack trace.
<br><br></details>

<details>
<summary><b>
    
6. When using ``Parse`` method, you can get errors e.g. ``int count = int.Parse("abc");``. How can you avoid exception errors?
</b></summary>

* Using the ``TryParse`` method - it returns ``true`` if it can convert and ``false`` if not:
```C#
Write("How many eggs are there? ");
string? input = ReadLine(); // try int and string

if (int.TryParse(input, out int count))
{
WriteLine($"There are {count} eggs.");
}
else
{
WriteLine("I could not parse the input.");
}
```
* The ``count`` variable name is a local variable with the parsed output.
<br><br></details>


<details>
<summary><b>

7. What happens when you divide an int variable by 0?
</b></summary>

* Error will be shown: ``System.DivideByZeroException``
<br><br></details>


<details>
<summary><b>

8. What happens when you divide a double variable by 0?
</b></summary>

* Outputs ``infinity``
<br><br></details>


<details>
<summary><b>

9. What happens when you overflow an int variable, that is, set it to a value beyond its range?
</b></summary>

* Using the ``unchecked`` keyword: It cycles back to the lowest integer value. i.e. ``int x = int.MaxValue + 1`` would output ``-2147483648``
* Using the ``checked`` keyword: Overflow exception thrown (at compile time).
<br><br></details>


<details>
<summary><b>

10. What is the difference between x = y++; and x = ++y;?
</b></summary>

* The first one assigns the value to x, then increments.
* The second one increments then assigns the value to x.
<br><br></details>


<details>
<summary><b>

11. What is the difference between break, continue, and return when used inside a loop statement?
</b></summary>

* ``break`` break exits the loop
* ``return`` ends current method call and continue executing after the method call.
* ``continue`` carries onto the next condition evaluation (whether while, for loop or switch)  or next interaction of loop.
<br><br></details>


<details>
<summary><b>

12. What are the three parts of a ``for`` statement and which of them are required?
</b></summary>

* Initaialiser, condition, incrementor
* The condition is required
<br><br></details>


<details>
<summary><b>

13. What is the difference between the ``=`` and ``==`` operators?
</b></summary>

* One assigns, the other compares equality.
<br><br></details>


<details>
<summary><b>

14. Does the following statement compile? ``for ( ; true; ) ;``
</b></summary>

* Yes it compiles. It is an infinite for loop.
<br><br></details>


<details>
<summary><b>

15. What does the underscore ``_`` represent in a switch expression?
</b></summary>

* Default return value
<br><br></details>


<details>
<summary><b>


16. What interface must an object implement to be enumerated over by using the for-each statement?
</b></summary>

* The ``IEnumerable`` interface. It must have the correct methods with the correct signatures even if the object does not actually implement the interface.
<br><br></details>

<details>
<summary><b>

17. What will happen if this code executes? What code could you add (don't change any of the preceding code) to warn us about the
problem?
    ```C#
    int max = 500;
    for (byte i = 0; i < max; i++)
    {
        WriteLine(i);
    }
    ```
</b></summary>

* The max value of a byte is 255, therefore, the above code will go into an infinite loop since the local variable ``i`` will never reach ``499``. The value ``i`` will keep cycling through 0-255.
* If the ``check`` keyword is used, an overflow exception is thrown.
<br><br></details>


<details>
<summary><b>

18. FizzBuzz is a group word game for children to teach them about division. Players take turns to count incrementally, replacing any number divisible by three with the word fizz, any number divisible by five with the word buzz, and any number divisible by both with fizzbuzz.

Create a console application in Chapter03 named Exercise03 that outputs a simulated FizzBuzz game counting up to 100.
</b></summary>

* My answer:
    ```C#
    for (int i = 0; i <= 100; i++)
    {
        if ((i % 3 == 0) && (i % 5 == 0))
        {
            WriteLine("fizzbuzz");
        }
        else if (i % 3 == 0)
        {
            WriteLine("fizz");
        }
        else if (i % 5 == 0)
        {
            WriteLine("buzz");
        }
        else 
        {
            WriteLine(i);
        } 
    }
    ```

<br><br></details>

<details>
<summary><b>

19. Create a console application that asks the user for two numbers in the range 0-255 and then divides the first number by the second
</b></summary>
* My answer:
    ``` C#
    Write("Enter a number between 0 and 255: ");
    int firstVal = int.Parse(ReadLine());
    Write("Enter another number between 0 and 255: ");
    int secondVal = int.Parse(ReadLine());

    WriteLine($"{firstVal} divided by {secondVal} is {firstVal / secondVal}");
    ```
<br><br></details>

<details>
<summary><b>

20. Write exception handlers to catch any thrown errors (continued from Q19).
</b></summary>
* My answer:
    ```C#
    try
    {
        Write("Enter a number between 0 and 255: ");
        int firstVal = int.Parse(ReadLine());
        Write("Enter another number between 0 and 255: ");
        int secondVal = int.Parse(ReadLine());

        WriteLine($"{firstVal} divided by {secondVal} is {firstVal / secondVal}");
    }
    catch (FormatException)
    {
        WriteLine("Something went wrong. Invalid format!");
    }
    catch (Exception ex)
    {
        WriteLine($"{ex.GetType()} says {ex.Message}");
    }
    ```
<br><br></details>

<details>
<summary><b>
    
21. What are the values of x and y after the following statement executes? ```x = 3; y = 2 + ++x;```

</b></summary>

* x = 4, y = 6
<br><br></details>
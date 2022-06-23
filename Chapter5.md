# Ch5 - Object-Oriented Programming
## Notes from Chapter 5 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [5.1 - Concepts of OOP](#05.1)
Building class libraries
Storing data with fields
Writing and calling methods
Controlling access with properties and indexers
Pattern matching with objects
Working with records

* [5.9 - Question & Answer](#05.9)

The code for this tutorial can be found in ``code/Chapter05``

---
<a name="05.1"></a>
### 5.1 - Concepts of OOP

* **Encapsulation**: This refers two important attributes of OOP: (1) bundling data and methods with an object (2) restricting how the internal state of an object can be accessed or modified from the outside (information hiding).
    
    >  For example, a ``BankAccount`` type might have data, such as ``Balance`` and ``AccountName``, as well as actions, such as ``Deposit`` and ``Withdraw``.

* **Composition**: What the object is made up of.
    
    >  For example, a ``Car`` is composed of different parts, such as four ``Wheel`` objects, several ``Seat`` objects, and an ``Engine``.

* **Aggregation**: What can be combined with an object.
    
    > For example, a ``Person`` is not part of a ``Car`` object, but they could sit in the driver's ``Seat`` and then become the car's ``Driver``—two separate objects that are aggregated together to form a new component.

* **Inheritance**: This is when the code is reused by using a ``subclass`` which derives from a ``superclass`` or ``base``. All the functionalities from the ``superclass`` is inherited by and becomes available in the derived class.
    
    > For example, the base or super ``Exception`` class has some members that have the same implementation across all exceptions, and the sub or derived ``SqlException`` class inherits those members and has extra members only relevant to when a SQL database exception occurs, like a property for the database connection.

* **Abstraction**: Abstraction is the concept of object-oriented programming that “shows” only essential attributes and “hides” unnecessary information.Is about capturing the core idea of an object and ignoring the details or the specifics. In C# and Java there is an ``abstract`` keyword which formalises this concept. Abstract classes are not used to instantiate objects, but to be used as a base for other classes.

    > The abstract class is used only to be inheritted, and it ensures certain methods are in place: (1) It may provide a method (2) It may force you to implement a specific method. For the ``abstract`` class Animal, we may implement an empty method as ``public abstract void animalSound();``, here the method does not do anything. When the Animal class is inheritted (``class Pig extends Animal``) the Pig class cannot be instantiated without overriding the method for ``animalSound()``. This forces the programmer to add ``animalSound()`` method to the subclass Pig.

* **Polymorphism**: Allows a derived ``subclass`` to override an inherited action to provide custom behaviours.

    > For example, overloading. This allows function with same name to act in different manner for different types. The function and the operator both can be overloaded.

---
<a name="05.2"></a>
### 5.2 - Building class libraries



---
<a name="05.12"></a>
### 5.12 - Question & Answer
<br>

<details>
<summary><b> 1. What is a functional language? and show example.</b></summary>
<br>

* Function languages evolved from lambda calculus (computational system based on functions)
* Some of the important attributes are modularity, immutability and maintainability.
* Example of functional-first program is F#, and purely functional is Haskell.
* Example of Pure Function:
    ```
    Function Pure(a,b)
    {
        return a+b;
    }
    ```
* Example of Impure Functions:
    ```
    int z;
    function notPure(){
        z = z+10;
    }
    ```
</details>





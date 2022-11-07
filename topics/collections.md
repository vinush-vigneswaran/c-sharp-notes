# Collections (C#)
## Notes based on [MS Docs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)

Return [Home](README.md)

---
## Collections vs Arrays

1. There are 2 ways to group objects, by creating:
    * Array of objects
    * Collections of objects

2. What is the difference between the two way of creating a group of objects?
    * Arrays are mainly useful when we have a ``fixed`` number of [strongly typed objects](#1.1) - we need to specify the length when the array instance is created.
    * Collections is dynamic, the group of objects can shrink or grow.
    * Retrieve by key for some collections - rather than array search

3. Generic Collections

    * ``System.Collections.Generic`` namespace can be used if your collections contains elements of only one data type - it enforces type safety!
    * We can define a generic list by using ``List<T>`` class:

        > Generic List<T> contains elements of specified type. It grows automatically as you add elements in it.

    ```C#
    List<int> primeNumbers = new List<int>();
    primeNumbers.Add(1); // adding elements using add() method
    primeNumbers.Add(3);
    ```
    * Here we only add one data type ``int`` to the list.
    * Using this provides methods to search, sort, and modify lists.
    * But there are also other generic collections: ``Dictionary<TKey,TValue> ``, ``SortedList<TKey,TValue>``, ``Queue<T>`` (FIFO), ``Stack<T>`` (LIFO) and many [more](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-6.0).
    * Wherever possible this should be used over the non-generic collections.
    * Collection is a class - therefore you must declare an instance of the class before adding elements.

4. Concurrent Collections
    * This is used when there are multiple threads accessing the collection concurrently.

5. Collections

    * ``System.Collections`` namespace can be used if you want a collection that is dynamic in size, but has the flexibility of storing any/different types.
    * Here the elements are not stored as specifically typed objects but as the objects of type ``Object``.
    * We can define a collection list by using the ``ArrayList()`` class:
    ```C#
    using System.Collections;
    var arlist1 = new ArrayList();
    arlist1.Add(1);
    arlist1.Add("Bill");
    arlist1.Add(" ");
    arlist1.Add(true);
    arlist1.Add(4.5);
    arlist1.Add(null);
    ```
    * This is different from the arrays in C# (``string[] cars;``) because it can grow/shrink dynamically. But it is same in the sense that we can have any objects in the array.

6. Example of Simple Collection

    ```C#
    // Create a list of strings.
    var salmons = new List<string>();
    salmons.Add("chinook");
    salmons.Add("coho");
    salmons.Add("pink");
    salmons.Add("sockeye");

    // Iterate through the list.
    foreach (var salmon in salmons)
    {
        Console.Write(salmon + " ");
    }
    // Output: chinook coho pink sockeye
    ```
7. Example of Simple Collection with Collection Initialiser
    ```C#
    var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
    // Remove an element from the list by specifying the object.
    salmons.Remove("coho");

    // Iterate through the list.
    foreach (var salmon in salmons)
    {
        Console.Write(salmon + " ");
    }
    // Output: chinook pink sockeye
    ```
8. Removing element using index in Generic list
    * In this example, we iterate **backwards** because the ``RemoveAt`` function causes elements **after** a removed element to have a lower index value. Moving backwards means we do not need to worry about the index being re-assigned as it gets removed.
    ```C#
    var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    // Remove odd numbers.
    for (var index = numbers.Count - 1; index >= 0; index--)
    {
        if (numbers[index] % 2 == 1)
        {
            // Remove the element by specifying
            // the zero-based index in the list.
            numbers.RemoveAt(index);
        }
    }

    // Iterate through the list.
    // A lambda expression is placed in the ForEach method
    // of the List(T) object.
    numbers.ForEach(
        number => Console.Write(number + " "));
    // Output: 0 2 4 6 8
    ```
9. Generic List with instances of a Custom Class
    * Here we are making our own class called Galaxy.
    * We are then storing a list of instances of Galaxy.

    ```C#
    private static void IterateThroughList()
    {
        var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25},
                new Galaxy() { Name="Milky Way", MegaLightYears=0},
                new Galaxy() { Name="Andromeda", MegaLightYears=3}
            };

        foreach (Galaxy theGalaxy in theGalaxies)
        {
            Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
        }

        // Output:
        //  Tadpole  400
        //  Pinwheel  25
        //  Milky Way  0
        //  Andromeda  3
    }

    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }
    ```

10. Generic Collection of Key/Value Pairs (Dictionary)

    * In the program below:
        * Given the symbol, name and atomic number we create an element object.
        * We then add that to a dictionary using the ``elements.Add(key: , value: )`` function.
        * Here the key is the element symbol, and the value is an instance of the Element class (element object).
    ```C#
    private static void IterateThruDictionary()
    {
        Dictionary<string, Element> elements = BuildDictionary();

        foreach (KeyValuePair<string, Element> kvp in elements)
        {
            Element theElement = kvp.Value;

            Console.WriteLine("key: " + kvp.Key);
            Console.WriteLine("values: " + theElement.Symbol + " " +
                theElement.Name + " " + theElement.AtomicNumber);
        }
    }

    private static Dictionary<string, Element> BuildDictionary()
    {
        var elements = new Dictionary<string, Element>();

        AddToDictionary(elements, "K", "Potassium", 19);
        AddToDictionary(elements, "Ca", "Calcium", 20);
        AddToDictionary(elements, "Sc", "Scandium", 21);
        AddToDictionary(elements, "Ti", "Titanium", 22);

        return elements;
    }

    private static void AddToDictionary(Dictionary<string, Element> elements,
        string symbol, string name, int atomicNumber)
    {
        Element theElement = new Element();

        theElement.Symbol = symbol;
        theElement.Name = name;
        theElement.AtomicNumber = atomicNumber;

        elements.Add(key: theElement.Symbol, value: theElement);
    }

    public class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }

    ```
    * Using an initialiser we can remove the ``AddToDictionary()`` function.
    ```C#
    private static Dictionary<string, Element> BuildDictionary2()
    {
        return new Dictionary<string, Element>
        {
            {"K",
                new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
            {"Ca",
                new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
            {"Sc",
                new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
            {"Ti",
                new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
        };
    }
    ```
    * To find using a key, we use ``elements[symbol]``, and to check if the key exists we use ``elements.ContainsKey(symbol)``:
    ```C#
    private static void FindInDictionary(string symbol)
    {
        Dictionary<string, Element> elements = BuildDictionary();

        if (elements.ContainsKey(symbol) == false)
        {
            Console.WriteLine(symbol + " not found");
        }
        else
        {
            Element theElement = elements[symbol];
            Console.WriteLine("found: " + theElement.Name);
        }
    }
    ```
    ---
## Keyword Definitions

<a name="1.1"></a>
* **Strongly typed Objects** - A programming language is strongly typed if it demands the specification of data types. 
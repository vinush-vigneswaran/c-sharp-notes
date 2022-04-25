# Ch4 - Writing, Debugging, and Testing Functions
## Notes from Chapter 4 "C# 10 and .NET 6" by Mark J. Price

## Contents
Return [Home](README.md)
* [4.1 - Don't Repeat Yourself (DRY)](#04.1)
* [4.2 - Post- and Pre- Incrementors](#04.2)
* [4.3 - Short-circuiting Boolean Operators](#04.3)



* [4.15 - Question & Answer](#04.11)

The code for this tutorial can be found in ``code/Chapter04``

---
<a name="04.1"></a>
### 4.1 - Don't Repeat Yourself (DRY)

* Use functions to avoid writing the same code again.
* Create a function that given an integer outputs the timetable for that value up to 12:
    ```C#
    using static System.Console;
    public class TimesTableApp
    {
        public static void Main(string[] args)
        {
            getTimesTable(11);
        }
        
        private static void getTimesTable(int xVal)
        {
            for (int x = 1; x <= 12; x++) 
            { 
            WriteLine($"{xVal} x {x} = {x * xVal}");
            }
            
            string xValString = xVal.ToString();
        }
    }
    ```
* In my example, I use ``int xVal`` but it is better to use strong types to add constraints to values. We know we will only need the range of timetables 1-15, therefore instead of ``int`` with range of -2,147,483,648 to 2,147,483,647, it would be more appropriate to use ``byte xVal``, with range of 0 to 255.
* Below we will write a function that returns a value, and uses a switch case:
    ```C#
    public class CalculateTaxApp
    {
        public static void Main(string[] args)
        {
            WriteLine(CalculateTax(1000, "GB"));
        }
        static decimal CalculateTax(
        decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maine
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }
    }
    ```
* As you can see for ``GB`` case it would have a rate of ``0.02M`` because there is no ``break``, and the program flows to the next case.








Going through the Tricentis tutorial, and also creating my own scenarios for the web framework - and playing around.











---
<a name="04.11"></a>
### 4.11 - Question & Answer
<br>

<details>
<summary><b> 1. What is the difference between a while loop and a do-while loop?</b></summary>
<br>

The while loop checks the condition then runs the statement, whereas the do-while loop, runs the statement first then check if the condition is still true.
<br><br>
</details>



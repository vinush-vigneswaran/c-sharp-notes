// See h// FizzBuzz

using static System.Console;

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

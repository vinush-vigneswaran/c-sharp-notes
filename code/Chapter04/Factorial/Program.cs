using static System.Console;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFactorial(20); 
        }
        static void RunFactorial(int nVals)
        {
            for (int i = 1; i <= nVals; i++)
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (System.OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
        }

        static int Factorial(int i)
        {
            if (i < 1)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 1;
            }
            else
            checked
            {
                return i * Factorial(i - 1);
            }
        }


    }
}

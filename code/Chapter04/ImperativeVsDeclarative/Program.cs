using static System.Console;
using static Cardinal2OrdinalApp.CardinalToOrdinalConvertor;

namespace ImperativeVsDeclarative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RunFib("imperative");
            RunFib("functional");
        }

        // Imperative style for fib value
        // Find the fib value given the nth term
        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        // Run the imperative style for fib seq
        // Create sequence
        static void RunFib(string type)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (type == "imperative")
                {
                    WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                    arg0: CardinalToOrdinal(i),
                    arg1: FibImperative(term: i));
                }
                else if (type == "functional")
                {
                    WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                    arg0: CardinalToOrdinal(i),
                    arg1: FibFunctional(term: i));
                }

            }
        }

        // Declarative Style
        // Find the fib value given the nth term
        static int FibFunctional(int term) =>
        term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };







    }
}

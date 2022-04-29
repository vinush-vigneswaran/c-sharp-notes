using static System.Console;

namespace ExploringDebugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");
            WriteLine("Press ENTER to end the app.");
            ReadLine(); // wait for user to press ENTER
        }

        static double Add(double a, double b)
        {
            return a * b; // deliberate bug!
        }
    }
}

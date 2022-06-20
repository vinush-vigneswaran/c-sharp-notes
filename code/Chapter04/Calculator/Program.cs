using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double answer = Packt.Calculator.Add(3.0, 2.5);
            Console.WriteLine($"Answer is {answer}");
        }

    }
}

namespace Packt
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a * b;
        }
    }
}
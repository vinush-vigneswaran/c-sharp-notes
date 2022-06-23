using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Packt.CalculatorLib calculate = new();
            double answer = calculate.Add(3.0, 2.5);
            Console.WriteLine($"Answer is {answer}");
        }

    }
}

namespace Packt
{
    public class CalculatorLib
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
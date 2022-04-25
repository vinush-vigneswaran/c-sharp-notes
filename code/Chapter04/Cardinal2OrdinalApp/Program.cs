using static System.Console;

namespace Cardinal2OrdinalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++) 
            {
                WriteLine(CardinalToOrdinal(i));
            }
            
        }

        // Create a function that converts cardinal int to ordinal string
        static string CardinalToOrdinal(int number) 
        {
            string ordinalSuffix = "";

            switch (number) 
            {
                case 11:
                case 12:
                case 13:
                    ordinalSuffix = "th";
                    break;
                default:
                    int lastVal = number % 10;
                    if (lastVal == 1)
                    {
                        ordinalSuffix = "st";
                    }
                    else if (lastVal == 2)
                    {
                        ordinalSuffix = "nd";
                    }
                    else if (lastVal == 3)
                    {
                        ordinalSuffix = "rd";
                    }
                    else 
                    {
                        ordinalSuffix = "th";
                    }
                    break;
            }
            {
                return ($"{number}{ordinalSuffix}");
            }
        
        }












    }
}

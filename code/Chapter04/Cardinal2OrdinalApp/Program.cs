using static System.Console;

namespace Cardinal2OrdinalApp
{
    public class CardinalToOrdinalConvertor
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++) 
            {
                WriteLine(CardinalToOrdinal(i));
            }
            
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        public static string CardinalToOrdinal(int number) 
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

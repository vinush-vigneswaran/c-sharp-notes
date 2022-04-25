using static System.Console;
public class TimesTableApp
{
    public static void Main(string[] args)
    {
        getTimesTable(255);
    }
    
    private static void getTimesTable(byte xVal)
    {
        for (int x = 1; x <= 12; x++) 
        { 
        WriteLine($"{x} x {xVal} = {x * xVal}");
        }
        
        string xValString = xVal.ToString();
    }
}
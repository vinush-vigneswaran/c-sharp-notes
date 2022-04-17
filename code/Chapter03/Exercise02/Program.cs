using static System.Console;

try
{
    unchecked{ int max = 500;
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
}
catch (Exception ex) { 
    Console.WriteLine(ex.ToString());
}
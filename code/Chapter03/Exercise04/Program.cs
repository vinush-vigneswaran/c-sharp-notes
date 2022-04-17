// See https://aka.ms/new-console-template for more information
using static System.Console;


try
{
    Write("Enter a number between 0 and 255: ");
    int firstVal = int.Parse(ReadLine());
    Write("Enter another number between 0 and 255: ");
    int secondVal = int.Parse(ReadLine());

    WriteLine($"{firstVal} divided by {secondVal} is {firstVal / secondVal}");
}
catch (FormatException)
{
    WriteLine("Something went wrong. Invalid format!");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
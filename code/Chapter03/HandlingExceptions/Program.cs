using static System.Console;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine(); // or use "49" in a notebook
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");
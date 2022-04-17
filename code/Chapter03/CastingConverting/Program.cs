using static System.Console;

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
//int d = c; // compiler gives an error for this line
//WriteLine(d);

// Parse method

Write("How many eggs are there? ");
string? input = ReadLine(); // try int and string

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}
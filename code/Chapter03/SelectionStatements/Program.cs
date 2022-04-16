using static System.Console;

string password = "ninja";

// Branching

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong.");
}

// Pattern matching

object o = "3";// change to 3 instead of "3" to run through other branch.
int j = 4;
if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

// Switch statements

int number = (new Random()).Next(1, 7);
number = 5;
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statement
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // multiple case section
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // end of switch statement

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

// Pattern Matching with Switch Case

// string path = "/Users/markjprice/Code/Chapter03";
string path = @"C:/Users/VINUS/Documents/35_CSHARP/c-sharp-notes/code/Chapter03";
Write("Press R for read-only or W for writeable: ");

ConsoleKeyInfo key = ReadKey();
WriteLine();
Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(
    Path.Combine(path, "file.txt"),
    FileMode.OpenOrCreate,
    FileAccess.Read);
}
else
{
    s = File.Open(
    Path.Combine(path, "file.txt"),
    FileMode.OpenOrCreate,
    FileAccess.Write);
}

string message;

switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        // If s.CanWrite is true (i.e. it is a write-able file)
        // and it its of class FileStream
        // then use writeableFile as the local variable of type FileStream (Class).
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        // Otherwise, if it's a FileStream and not Writeable then 
        // it is a readOnlyFile
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    default: // always evaluated last despite its current position
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null.";
        break;
}
WriteLine(message);
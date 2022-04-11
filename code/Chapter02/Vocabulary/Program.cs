// See https://aka.ms/new-console-template for more information
// #error version

using System.Reflection;
// declare some unused variables using types (ds and client)
// in additional assemblies
System.Data.DataSet ds;
HttpClient client;

//////////////////////////////// Methods ////////////////////////////////
Console.WriteLine("\n--- Method Ouputs ---\n");


// outputs the current line terminator string
// by default, this is a carriage-return and line feed (enter)
Console.WriteLine();

// outputs the greeting and the current line terminator string
Console.WriteLine("Hello Ahmed");

// outputs a formatted number and date and the current line terminator string
Console.WriteLine("Temperature on {0:D} is {1}°C.",
DateTime.Today, 23.4);



////////////////////////////////// Types and Methods Available ////////////////////////////////
// Lets see the number of types and methods available 

Console.WriteLine("\n--- Types and Methods Available ---\n");
Assembly? assembly = Assembly.GetEntryAssembly();

if (assembly == null) return;

// loop through the assemblies that this app references
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);
    // declare a variable to count the number of methods
    int methodCount = 0;
    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    // output the count of types and their methods
    Console.WriteLine(
    "{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount, arg2: name.Name);
}
// load the assembly so we can read its details
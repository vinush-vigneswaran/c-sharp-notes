using static System.Console;

// Exploring bitwise and binary shift operators

int a = 10; // 00001010
int b = 6; // 00000110

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); // 2-bit column only
WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns

WriteLine(nameof(a)); // 8 and 4-bit columns
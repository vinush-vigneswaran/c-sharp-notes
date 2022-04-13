using static System.Console;

int a = 3;
int b = a++; // increment a after assigning it

WriteLine($"a is {a}, b is {b}");


int c = 3;
int d = ++c; // increment c before assigning it

WriteLine($"c is {c}, d is {d}");
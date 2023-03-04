/* C# Type Casting
Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:

Implicit Casting (automatically) -converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) -converting a larger type to a smaller size type
double -> float -> long -> int -> char

Implicit Casting   
int myInt = 9;                    double > int
double myDouble = myInt;       // Automatic casting: int to double
Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9


Explicit Casting
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int
Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
*/
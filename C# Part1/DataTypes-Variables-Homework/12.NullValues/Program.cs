using System;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class Program
{
    static void Main(string[] args)
    {
        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine(nullInteger);
        Console.WriteLine(nullDouble);

        nullInteger += 5;
        nullDouble += null;

        Console.WriteLine(nullInteger);
        Console.WriteLine(nullDouble);

        // it creates 4 empty lines , because all of the types stay null all the time. Null -> No value
    }
}
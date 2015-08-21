using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        Console.Write("b = ");
        int b = Math.Abs(int.Parse(Console.ReadLine()));

        while (a != b)
        {
            if (a > b)
               a = a - b;
            else
               b = b - a;
        }
        Console.WriteLine(a);
    }
}

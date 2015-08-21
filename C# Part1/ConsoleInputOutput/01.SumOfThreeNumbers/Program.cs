using System;

// Write a program that reads 3 real numbers from the console and prints their sum.

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Sum is {0}", a + b + c);
    }
}


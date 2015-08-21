using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) * h / 2;

        Console.WriteLine("The area of trapezoid is {0} ", area);
    }
}

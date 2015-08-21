using System;

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInside = (x * x + y * y) <= 4;

        Console.WriteLine(isInside);
    }
}

using System;

// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
// and solves it (prints its real roots).

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        // if a == 0 it means the equation is linear
        if (a == 0)
            Console.WriteLine("x1 = " + (-c / b));
        else
        {
            double D = b * b - 4 * a * c; // Discriminant

            // Negative D means no real roots
            if (D < 0)
                Console.WriteLine("No real roots!");
            // D == 0 means 2 equal roots
            else if (D == 0)
                Console.WriteLine("x1 = x2 = " + (-b / 2 * a));
            // D > 0 means 2 real roots
            else
                Console.WriteLine("x1 = {1}  ,  x2 = {0}", ((-b + Math.Sqrt(D))) / (2 * a), ((-b - Math.Sqrt(D))) / (2 * a));
        }
    }
}

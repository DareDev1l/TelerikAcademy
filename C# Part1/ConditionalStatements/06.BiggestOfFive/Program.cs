using System;

// Write a program that finds the biggest of five numbers by using only five if statements.

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double maxValue = a;

        if (b > maxValue)
        {
            maxValue = b;
        }
        else if (c > maxValue)
        {
            maxValue = c;
        }
        else if (d > maxValue)
        {
            maxValue = d;
        }
        else if (e > maxValue)
        {
            maxValue = e;
        }

        Console.WriteLine("Biggest number is : {0}", maxValue);

        // Short solution:
        // Console.WriteLine(Math.Max(a,b,c,d,e));
    }
}
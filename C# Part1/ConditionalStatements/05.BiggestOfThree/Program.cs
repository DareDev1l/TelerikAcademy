using System;

// Write a program that finds the biggest of three numbers.

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double maxValue = a;

        if(b > maxValue)
        {
            maxValue = b;
        }
        else if(c > maxValue)
        {
            maxValue = c;
        }

        Console.WriteLine("Biggest number is : {0}", maxValue);

        // Short solution:
        // Console.WriteLine(Math.Max(a,b,c));
    }
}
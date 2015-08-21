using System;

// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(random.Next(min,max+1));
        }
    }
}
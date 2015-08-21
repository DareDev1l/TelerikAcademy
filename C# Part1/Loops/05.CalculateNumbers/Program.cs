using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        uint factoriel = 1;

        for (uint i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += factoriel / (Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
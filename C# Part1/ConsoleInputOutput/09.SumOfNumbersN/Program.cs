using System;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSum is {0}", sum);
    }
}

using System;
 
// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(' ');
        double sum = 0;

        for (int i = 0; i < stringNumbers.Length; i++)
        {
            sum += double.Parse(stringNumbers[i]);
        }
        Console.WriteLine("Sum is {0}", sum);
    }
}


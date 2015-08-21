//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integers with interval between them:");
        string input = Console.ReadLine();
        string[] splitInput = input.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;

        for (int i = 0; i < splitInput.Length; i++)
        {
           sum += int.Parse(splitInput[i]);
        }

        Console.WriteLine("Sum of integers is {0}", sum);
    }
}
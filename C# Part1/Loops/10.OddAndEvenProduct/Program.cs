using System;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbersAsString = new string[(input.Length+1)/2];
        int[] numbers = new int[(input.Length+1)/2];
        int oddSum = 1;
        int evenSum = 1;

        // 1. Store the numbers in an array
        numbersAsString = input.Split(' ');

        for (int i = 0; i < (input.Length+1)/2; i++)
        {
            numbers[i] = int.Parse(numbersAsString[i]);
        }

        // 2. Calculate sum of even numbers , then odd
        for (int i = 0; i < (input.Length + 1) / 2; i += 2) 
        {
            oddSum *= numbers[i];
        }
        for (int i = 1; i < (input.Length + 1) / 2; i += 2)
        {
            evenSum *= numbers[i];
        }

        // 3. Print yes if sums are equal , print no if they are not
        if (evenSum == oddSum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
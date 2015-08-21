using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 7, 5, 2, 1, 9, 0, 32, 13, 5 };

        // k = 1   -->  32
        // k = 2   -->  45
        // k = 3   -->  54 
        // k = 10  -->  75

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int maxSum = 0;

        Array.Sort(arr);

        for (int i = arr.Length - k; i < arr.Length; i++)
        {
            maxSum += arr[i];   
        }

        Console.WriteLine(maxSum);
    }
}

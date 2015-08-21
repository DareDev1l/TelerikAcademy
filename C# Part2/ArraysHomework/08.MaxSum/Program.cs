using System;

// Write a program that finds the sequence of maximal sum in given array

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = int.MinValue;
        int maxIndexStart = 0;
        int maxIndexEnd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            int counter = i;

            while (counter < arr.Length)
            {
                sum += arr[counter];
                if(sum > maxSum)
                {
                    maxIndexStart = i;
                    maxSum = sum;
                    maxIndexEnd = counter;
                }
                counter++;
            }
        }

        for (int i = maxIndexStart; i <= maxIndexEnd; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}
using System;

// Write a program that finds in given array of integers a sequence of given sum S (if present)

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            int counter = i;

            while (counter < arr.Length)
            {
                sum += arr[counter];
                if (sum == s)
                {
                    for (int j = i; j <= counter; j++)
                    {
                        found = true;
                        Console.Write("{0} ", arr[j]);
                    }
                    Console.WriteLine();
                    break;
                }
                counter++;
            }
        }

        if (!found)
        {
            Console.WriteLine("No sequence of numbers to sum {0}", s);
        }

    }
}
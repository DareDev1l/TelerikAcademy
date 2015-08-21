using System;

// Write a program that reads two positive integer numbers and prints how many numbers p exist between
// them such that the reminder of the division by 5 is 0.

class Program
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;

        Console.WriteLine();
        // Iterate through elements from 'start' positiong to 'end' position
        for (int i = start; i <= end; i++)
        {
            // if that element is dividable by 5
            if (i % 5 == 0)
            {
                Console.Write("{0} ",i);
                p++;
            }
        }
        Console.WriteLine("\nNumbers dividable by 5 ---> {0}", p);
    }
}
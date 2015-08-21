using System;

// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …


class Program
{
    static void Main(string[] args)
    {
        // Loop through the instruction 10 times , incrementing 'i' each time starting from i = 2
        for (int i = 2; i < 1002; i++)
        {
            // check if 'i' is even 
            if (i % 2 == 0)
            {
                Console.Write(i);
                Console.Write("  ");
            }
            // if 'i' is not even ('i' is odd) 
            else
            {
                Console.Write(-i);
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}

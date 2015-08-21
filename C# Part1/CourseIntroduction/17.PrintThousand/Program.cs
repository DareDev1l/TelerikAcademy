using System;

// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …


class Program
{
    static void Main(string[] args)
    {
        // Without this line , the code will not show all the numbers
        // It would show less than 300 , that's why we instruct the 
        // console to show up to 1001 rows(last one is for "Press any key to continue...")
        Console.BufferHeight = 1001;

        for (int i = 1; i < 1001; i++)
        {
            Console.WriteLine(i);
        }
    }
}

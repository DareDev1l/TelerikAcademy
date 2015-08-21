using System;

// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

class Program
{
    static void Main(string[] args)
    {
        // This is the example from the site
        // It should return 236476736
        string input = "1110000110000101100101000000"; // Console.ReadLine();
        int numberInDecimal = 0;

        for (int i = input.Length - 1; i >= 0 ; i--)
        {
            int bit = (int)(input[i] - '0');
            numberInDecimal += (int)(Math.Pow(2.0, (double)input.Length - i - 1)) * bit;
        }
        Console.WriteLine(numberInDecimal);
    }
}
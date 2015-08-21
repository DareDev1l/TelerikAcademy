// Write a program to convert binary numbers to their decimal representation.

using System;
class Program
{
    static int BinaryToDecimal(string input)
    {
        
        int numberInDecimal = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int bit = (int)(input[i] - '0');
            numberInDecimal += (int)(Math.Pow(2.0, (double)input.Length - i - 1)) * bit;
        }
        return numberInDecimal;
    }


    static void Main()
    {
        // You can modify input as you wish
        string input = "0000000000000000000000000111"; // Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(input));
    }
}
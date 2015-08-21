//Write a program to convert decimal numbers to their binary representation.

using System;
class Program
{
    static char[] DecimalToBinary(long decimalNumber)
    {
        string digits = String.Empty;

        while (decimalNumber != 0)
        {
            digits += (decimalNumber % 2).ToString();
            decimalNumber /= 2;
        }

        char[] digitsAsChars = digits.ToCharArray();
        Array.Reverse(digitsAsChars);
        return digitsAsChars;
    }

    static void Main()
    {
        Console.Write("Enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinary(n));
    }
}
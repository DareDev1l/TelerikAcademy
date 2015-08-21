// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class Program
{
    static string ShortToBinary(short decimalNumber)
    {
        string digits = String.Empty;
        char sign = '0';

        if(decimalNumber < 0)
        {
            sign = '1';
            decimalNumber = (short)-decimalNumber;
        }

        while (decimalNumber != 0)
        {
            digits += (decimalNumber % 2).ToString();
            decimalNumber /= 2;
        }

        char[] digitsAsChars = digits.ToCharArray();
        Array.Reverse(digitsAsChars);

        string result = string.Empty;

        for (int i = 0; i < digitsAsChars.Length; i++)
        {
            result += digitsAsChars[i];
        }
        result = result.PadLeft(15, '0');
        result = sign + result;
        return result;
    }

    static void Main()
    {
        Console.Write("Enter short number:");
        short input = short.Parse(Console.ReadLine());
        Console.WriteLine(ShortToBinary(input));
    }
}
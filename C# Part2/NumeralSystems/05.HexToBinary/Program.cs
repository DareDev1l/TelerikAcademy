// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
class Program
{
    static string DecimalToBinary(long decimalNumber)
    {
        string digits = String.Empty;

        while (decimalNumber != 0)
        {
            digits += (decimalNumber % 2).ToString();
            decimalNumber /= 2;
        }

        char[] digitsAsChars = digits.ToCharArray();
        Array.Reverse(digitsAsChars);
        for (int i = 0; i < digitsAsChars.Length; i++)
        {
            digits += digitsAsChars[i];
        }
        return digits;
    }

    static string HexToBinary(string input)
    {
        string binaryNum = String.Empty;
        int digit;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if(input[i] < '9' && input[i] > '0')
            {
                digit = input[i] - '0';
            }
            else
            {
                digit = input[i] - '0' - 7;
            }

            binaryNum += DecimalToBinary(digit).PadLeft(4, '0');
        }

        return binaryNum;
    }

    static void Main(string[] args)
    {
        // FFFF - 32 '1'
        string binary = HexToBinary("FF"); // 255
        Console.WriteLine(binary);
    }
}
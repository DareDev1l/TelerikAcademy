//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Globalization;
class Program
{
    static void FormatNumber(int number)
    {
        CultureInfo provider = new CultureInfo("en-US");
        Console.WriteLine(number.ToString("D" , provider).PadLeft(15, ' '));
        Console.WriteLine(number.ToString("X", provider).PadLeft(15, ' '));
        Console.WriteLine(number.ToString("P1", provider).PadLeft(15, ' '));
        Console.WriteLine(number.ToString("E", provider).PadLeft(15, ' '));

    }
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        FormatNumber(input);
    }
}
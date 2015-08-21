using System;

// Write an expression that checks for given integer if its third digit from right-to-left is 7.


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = (number / 100) % 10;
        bool isThirdDigitSeven = thirdDigit == 7;

        Console.WriteLine(isThirdDigitSeven);
    }
}
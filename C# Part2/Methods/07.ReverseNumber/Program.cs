//Write a method that reverses the digits of given decimal number.

using System;
class Program
{
    static decimal ReverseNumber(decimal num)
    {
        char[] numChars = num.ToString().ToCharArray();
        Array.Reverse(numChars);

        string reversedNum = String.Empty;

        for (int i = 0; i < numChars.Length; i++)
        {
            reversedNum += numChars[i];
        }

        return decimal.Parse(reversedNum);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ReverseNumber(1234.567m));
    }
}
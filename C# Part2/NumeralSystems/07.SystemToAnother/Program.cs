//Write a program to convert from any numeral system of given base  s  to any other numeral system of base  d  (2 ≤  s ,  d  ≤ 16).

using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        // Base s
        Console.Write("Enter base s: ");
        byte baseS = byte.Parse(Console.ReadLine());

        // Number to convert
        Console.Write("Enter number from base s: ");
        string numberOneSystem = Console.ReadLine();

        // Base to convert to (d)
        Console.Write("Enter base d: ");
        byte baseD = byte.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(systemD(RandomBaseToDecimal(numberOneSystem, baseS), baseD));
    }
    static string systemD(long decimalNum, int baseToConvert)
    {
        string result = "";

        while (decimalNum > 0)
        {
            long digit = decimalNum % baseToConvert;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else if (digit >= 10 && digit <= 15)
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNum /= baseToConvert;
        }
        return result;
    }
    static long RandomBaseToDecimal(string num, int randomBase)
    {
        long decimalNumber = 0;
        for (int i = 0; i < num.Length; i++)
        {
            int digit = 0;
            if (num[i] >= '0' && num[i] <= '9')
            {
                digit = num[i] - '0';
            }
            else if (num[i] >= 'A' && num[i] <= 'F')
            {
                digit = num[i] - 'A' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(randomBase, num.Length - i - 1);
        }
        return decimalNumber;
    }
}
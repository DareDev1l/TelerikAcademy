using System;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

class Program
{
    static void Main(string[] args)
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        string digits = String.Empty;
        
        while (decimalNumber != 0)
        {
            digits += (decimalNumber%2).ToString();
            decimalNumber /= 2;
        }

        char[] digitsAsChars = digits.ToCharArray();
        Array.Reverse(digitsAsChars);
        Console.WriteLine(digitsAsChars); 
    }
}

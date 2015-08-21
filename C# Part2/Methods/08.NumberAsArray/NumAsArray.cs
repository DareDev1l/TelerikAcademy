//Write a method that adds two positive integer numbers represented as arrays of 
//digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits


using System;
using System.Collections.Generic;
using System.Numerics;
class NumAsArray
{
    static void Main()
    {
        Console.Write("Enter  first number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter second number: ");
        string secondNumber = Console.ReadLine();

        string result = CalculateNumbers(firstNumber, secondNumber);
        Console.WriteLine("{0}", result);
    }

    static string CalculateNumbers(string firstNumber, string num2)
    {
        int numberLength = (firstNumber.Length > num2.Length) ? firstNumber.Length : num2.Length;
        firstNumber = firstNumber.PadLeft(numberLength, '0');
        num2 = num2.PadLeft(numberLength, '0');


        char[] result = new char[numberLength];
        int remainder = 0;

        for (int i = numberLength - 1; i >= 0; i--)
        {
            result[i] = (char)(((firstNumber[i] + num2[i] - 2 * 48 + remainder) % 10) + 48);
            remainder = (firstNumber[i] + num2[i] - 2 * 48 + remainder) / 10;
        }

        string resultFinal = "";

        if (remainder > 0)
        {
            resultFinal = "1";
        }

        for (int i = 0; i < numberLength; i++)
        {
            resultFinal += result[i];
        }

        return resultFinal;
    }
}
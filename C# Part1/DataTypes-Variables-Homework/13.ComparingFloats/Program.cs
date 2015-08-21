using System;

// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
class Program
{
    static void Main(string[] args)
    {
        // declaring the two numbers
        double firstNumber; 
        double secondNumber;

        string a = Console.ReadLine();
        string b = Console.ReadLine();

        // System globalization is used for entering floating point numbers with '.' rather than ','
        firstNumber = double.Parse(a , System.Globalization.NumberFormatInfo.InvariantInfo);
        secondNumber = double.Parse(b , System.Globalization.NumberFormatInfo.InvariantInfo);

        double eps = 0.000001;

        Console.WriteLine((firstNumber - secondNumber) < eps);
    }
}

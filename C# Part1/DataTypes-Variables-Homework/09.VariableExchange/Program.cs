using System;

// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using
// some programming logic. Print the variable values before and after the exchange.

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = 6;
        int secondNumber = 9;
        int placeholder;

        Console.WriteLine("Before exchange:  firstNumber = " + firstNumber + " ,  secondNumber = " + secondNumber);

        // I use third variable placeholder which takes the value of first number.
        // firstNumber gets the value of secondNumber
        // Finally secondNumber gets value of placeholder (which holds the first value of firstNumber)

        placeholder = firstNumber;
        firstNumber = secondNumber;
        secondNumber = placeholder;

        Console.WriteLine();
        Console.WriteLine("After exchange:  firstNumber = " + firstNumber + " ,  secondNumber = " + secondNumber);
        Console.WriteLine();
    }
}
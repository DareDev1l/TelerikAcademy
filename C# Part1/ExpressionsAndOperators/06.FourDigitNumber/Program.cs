using System;
/*
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
 */


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int d = number % 10;
        int c = number / 10 % 10;
        int b = number / 100 % 10;
        int a = number / 1000;

        int sum = a + b + c + d;

        Console.WriteLine("Sum of digits: {0}", sum);
        Console.WriteLine("Reversed : " + d + "" + c + "" + b + "" + a);
        Console.WriteLine("Last digit in front: " + d + "" + a + "" + b + "" + c);
        Console.WriteLine("Middle digits reversed: " + a + "" + c + "" + b + "" + d);
    }
}
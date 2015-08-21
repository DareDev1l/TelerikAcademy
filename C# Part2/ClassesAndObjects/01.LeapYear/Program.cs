//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        bool isLeapYear = System.DateTime.IsLeapYear(year);
        if (isLeapYear)
        {
            Console.WriteLine("{0} is leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is not leap year", year);
        }
    }
}
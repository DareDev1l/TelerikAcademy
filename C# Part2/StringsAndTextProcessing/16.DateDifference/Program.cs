//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them

using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        Console.Write("Enter first date(day.month.year): ");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", provider);
        Console.Write("Enter second date(day.month.year): ");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", provider);
        int counter = 0;

        while(!(date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year))
        {
            date1 = date1.AddDays(1);
            counter++;
        }

        Console.WriteLine("Distance: {0} days", counter);
    }
}
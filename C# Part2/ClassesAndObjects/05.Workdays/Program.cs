//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Date until workdays
        DateTime date = new DateTime(2015, 03, 15);

        List<DateTime> holidays = new List<DateTime>()
        {
            new DateTime(2015, 02,14),  // Valentine's Day
            new DateTime(2015, 03, 03), // National praznik
            new DateTime(2015, 05, 06)  // Gergiovden
        };

        Console.WriteLine("Workdays: {0}", Workdays.NumberOfWorkDays(date, holidays));
    }
}

public class Workdays
{
    

    public static int NumberOfWorkDays(DateTime date, List<DateTime> holidays)
    {
        int workDays = 0;
        DateTime currentDate = DateTime.Now;

        while (!(currentDate.Day == date.Day && currentDate.Month == date.Month && currentDate.Year == date.Year))
        {
            currentDate = currentDate.AddDays(1);
            if (!holidays.Contains(new DateTime(currentDate.Year, currentDate.Month, currentDate.Day)))
            {
                if ((int)currentDate.DayOfWeek != 0 && (int)currentDate.DayOfWeek != 6)
                {
                    workDays++;
                }
            }
        }

        return workDays;
    }
}
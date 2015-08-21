//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along 
//with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo providerBG = CultureInfo.GetCultureInfo("bg-BG");
        CultureInfo provider = CultureInfo.InvariantCulture;
        string customDate = "d.M.yyyy HH:mm:ss";

        string input = "22.08.2015 20:30:15"; //Console.ReadLine()

        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        DateTime date = DateTime.ParseExact(input, customDate, provider).AddDays(6.5 / 24);
        Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), providerBG);
    }
}
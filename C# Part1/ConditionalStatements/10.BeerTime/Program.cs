using System;

/*
  A beer time is after 1:00 PM and before 3:00 AM.
  Write a program that enters a time in format “hh:mm tt” 
  (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
  and prints beer time or non-beer time according to the definition above or invalid 
  time if the time cannot be parsed.
  */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter time(depending on your regional settings) :  HH:MM tt");
        DateTime time = DateTime.Parse(Console.ReadLine());
        int hours = time.Hour;
        int minutes = time.Minute;

        // It converts
        if(hours > 3 && hours < 13)
            Console.WriteLine("non-beer time");
        else Console.WriteLine("beer time");


    }
}
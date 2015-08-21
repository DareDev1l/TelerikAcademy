using System;

// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class Program
{
    static void Main()
    {
        // Reading user birth date
        Console.WriteLine("Enter your birthday (DD/MM/YYYY) : ");
        string input = Console.ReadLine();
        DateTime birthDate = DateTime.Parse(input);

        if(DateTime.Now.Month < birthDate.Month && DateTime.Now.Day < birthDate.Day)
        {
            // If he didn't have birthday this year , we add 9 years from now on
            Console.WriteLine(DateTime.Now.Year - birthDate.Year + 9);
        }
        // If he had birthday, he will be 1 year older compared to the upper case, therefore we add 10 years
        else Console.WriteLine(DateTime.Now.Year - birthDate.Year + 10);

    }
}
using System;

// Write a Boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 at the same time.
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        // In order for number to be divided by both 7 and 5 , it should be divided by 35
        // because 7 and 5 are both prime numbers

        bool isDividable = number % 35 == 0;
        Console.WriteLine(isDividable);
    }
}
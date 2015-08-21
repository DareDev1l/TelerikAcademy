using System;
class Program
{
    // Write an expression that checks if given integer is odd or even.

    static void Main(string[] args)
    {
       int number = int.Parse( Console.ReadLine() );

       if (number % 2 == 0)
       {
           Console.WriteLine(number + " is even!");
       }
       else
       {
           Console.WriteLine(number + " is odd!");
       }

    }
}

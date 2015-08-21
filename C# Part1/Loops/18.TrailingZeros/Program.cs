using System;

// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int trailingZeros = 0;
        decimal num = 0;

        for (int i = 5; i <= n; i += 5)
        {
            num = i;
            while(num != 0)
            {
                if( num % 5 == 0)
                {
                    trailingZeros++;
                }
                num = num / 5;
            }
        }
        Console.WriteLine(trailingZeros);
    }
}
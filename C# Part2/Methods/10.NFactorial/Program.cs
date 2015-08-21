// Write a program to calculate n! for each n in the range [1..100].


using System;
using System.Numerics;
class Program
{
    static BigInteger FindFactorial(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter factorial n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}! = {1}", n , FindFactorial(n));
    }
}

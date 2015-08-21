using System;

// Write a program that finds all prime numbers in the range [1...10 000 000]

class Program
{
    static bool isPrime(int n)
    {
        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                isPrime = false;
            }
            
        }
        return isPrime;
    }

    static void Main(string[] args)
    {
        for (int i = 1; i < 1000000; i++)
        {
            if(isPrime(i))
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}
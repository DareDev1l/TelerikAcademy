using System;
using System.Numerics;

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (uint i = (uint)(k+1); i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
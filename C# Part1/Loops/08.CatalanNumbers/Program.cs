using System;
using System.Numerics;

//In combinatorics, the Catalan numbers are calculated by the following formula: (can't place image,  sorry :D)
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorielOne = 1;
        BigInteger factorielTwo = 1;

        for (uint i = (uint)(n + 1); i <= n * 2; i++) 
        {
            factorielOne *= i;
        }
        for (uint j = 2; j <= n+1; j++)
        {
            factorielTwo *= j;
        }
        Console.WriteLine(factorielOne / factorielTwo);
    }
}
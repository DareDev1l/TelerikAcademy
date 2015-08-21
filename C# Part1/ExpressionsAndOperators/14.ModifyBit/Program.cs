using System;

// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the
// binary representation of n while preserving all other bits in n.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        int mask,result;

        if(v==1)
        {
            mask = 1 << p;
            result = number | mask;
        }
        else
        {
            mask = ~(1 << p);
            result = number & mask;
        }
        Console.WriteLine("Result : {0}", result);
    }
}


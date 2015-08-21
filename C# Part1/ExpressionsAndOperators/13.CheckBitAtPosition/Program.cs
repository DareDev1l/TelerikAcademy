using System;

// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
// in given integer number n, has value of 1.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;
        bool isOne=false;

        if (bit == 1) isOne = true;

        Console.WriteLine("Bit on position {1} has value 1 ? - {0}", isOne, p);
    }
}

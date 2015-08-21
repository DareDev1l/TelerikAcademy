using System;

// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> 3;

        Console.WriteLine("Bit on position 3 is : {0}", bit);
    }
}

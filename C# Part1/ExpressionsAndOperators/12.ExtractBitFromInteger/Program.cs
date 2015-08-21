using System;

// ite an expression that extracts from given integer n the value of given bit at index p.

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

        Console.WriteLine("Bit on position {0} is : {1}", p, bit);
    }
}

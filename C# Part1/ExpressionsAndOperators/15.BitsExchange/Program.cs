using System;

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class Program
{
    static void Main(string[] args)
    {
    
        uint n = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));


        // 1. Extract the bits from number (move them to most left and them most right to delete rest of the bits)
        //    and place them on the other bits' positions
        uint firstBits = ((n << 26) >> 29) << 24;
        uint secondBits = ((n << 5) >> 29) << 3;


        // Make the bits at positions we swap to 0s
        uint makeZeros;

        unchecked
        {
            uint baseMakeZeros = (uint)~(7 << 3);
            makeZeros = baseMakeZeros;
        }
       
        n = n & makeZeros;

        unchecked
        {
            makeZeros = ~(~makeZeros << 21);
        }

        n = n & makeZeros;

        // Bitwise OR to place the bits we extracted from the first number to the modified number with 0s
        n = (n | firstBits) | secondBits;
        Console.WriteLine("Changed number : " + n);
    }
}


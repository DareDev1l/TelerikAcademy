using System;

// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

class Program
{
    static void Main(string[] args)
    {
        // 1. Read numbers

        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        // 2. Extract the bits we have to swap and swap their positions with other bits' position

        uint firstBits = ((n << (31 - (p + k - 1)))>> (31 - k + 1)) << q;
        uint secondBits = ((n << (31 - (q + k - 1))) >> 31 - k + 1) << p;

        // 3. Change all the bits we swap to 0s , so we can use | and place exactly the bits we stored from point 2.
        uint makeZeros = 0;

        // 3.1  Find integer with so many 1s equal to bits we need to replace (k) (You probably need a little math here)
        for (int i = 0; i < k; i++)
        {
            makeZeros += (uint)Math.Pow(2.0, (double)i);
        }

        uint makeZeros2 = makeZeros;

        unchecked
        {
            // Move 1s from makeZeros to the position we have to make bits to 0
            makeZeros = ~(makeZeros << p);
        }

        n = n & makeZeros;

        unchecked
        {
            // same thing , but move it to the other bits' position we have to swap
            makeZeros2 = ~(makeZeros2 << q);
        }

        n = n & makeZeros2;

        // 4. Final step is to place the bits we stored in firstBits and secondBits to the new number
        //    which has 0s on the positions we have to write the bits

        n = (n | firstBits) | secondBits;

        // 5. Check if the bits overlap or number is out of range

        bool outOfRange = false;
        bool overlap = false;

        for (int i = p; i <= p + k - 1; i++)
        {
            for (int j = q; j <= q + k - 1; j++)
            {
                if (i == j)
                {
                    overlap = true;
                    break;
                }
            }
        }

        if ((p + k - 1) > 31 || (q + k - 1) > 31)
            outOfRange = true;

        // 6. Actions according if it is our of range , overlapping or valid

        if(outOfRange)
        {
            Console.WriteLine("Error! Out of range !");
        }
        else if(overlap)
        {
            Console.WriteLine("Error! Bits overlapping!");
        }
        else Console.WriteLine("Changed number is : " + n);

        // I hope comments are descriptive enough 
    }
}


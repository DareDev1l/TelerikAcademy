using System;

// Write a program that reads a rectangular matrix of size N x M and finds 
// in it the square 3 x 3 that has maximal sum of its elements.

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = 
        {
            {1,  2,  3,  4,  5},
            {6,  7,  8,  9,  10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };

        for (int s = 0; s < arr.GetLength(0); s++)
        {
            for (int p = 0; p < arr.GetLength(1); p++)
            {
                Console.Write("{0,-2} ", arr[s,p]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        int i = 0;
        int j = 0;
        int maxSum = 0;
        int maxI = 0;
        int maxJ = 0;

        // Find Max sum
        for (int row = 0; row < arr.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 2; col++)
            {
                int currentSum = 0;
                for (i = row; i < row + 3; i++)
                {
                    for (j = col; j < col + 3; j++)
                    {
                        currentSum += arr[i, j]; 
                    }
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxI = i-3;
                    maxJ = j-3;
                }
            }
        }


        // Print square with max sum
        for (i = maxI; i < maxI + 3; i++)
        {
            for (j = maxJ; j < maxJ + 3; j++)
            {
                Console.Write("{0,-2} ", arr[i,j]);
            }
            Console.WriteLine();
        }
    }
}
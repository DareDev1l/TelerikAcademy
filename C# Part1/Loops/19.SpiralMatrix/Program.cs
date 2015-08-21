using System;

// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
// a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int rows = n;
        int cols = n;
        int leftEnd = 1;
        int upperEnd = 2;
        int regulator = 0;
        int curPosI = 1;
        int curPosJ = 1;
        int curNumber = 1;
        int i, j;

        // Set matrix (square with side root of n)
        int[,] matrix = new int[n+1, n+1];

        // Assign 0s
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                matrix[i, j] = 0;
            }
        }

        // Until reaching last number
        while (curNumber <= n*n)
        {
            // 1. Going right until end
            if (regulator % 4 == 0)
            {
                while (curPosJ <= rows)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosJ++;
                }
                rows--;
                curPosI++;
                curPosJ--;
                regulator++;
            }
            // 2. Goind down until end 
            else if (regulator % 4 == 1)
            {
                while (curPosI <= cols)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosI++;
                }
                cols--;
                curPosJ--;
                curPosI--;
                regulator++;
            }
            // 3. Goind left until end 
            else if (regulator % 4 == 2)
            {
                while (curPosJ >= leftEnd)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosJ--;
                }
                leftEnd++;
                curPosI--;
                curPosJ++;
                regulator++;
            }
            // 4. Goind up until end 
            else if (regulator % 4 == 3)
            {
                while (curPosI >= upperEnd)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosI--;
                }
                upperEnd++;
                curPosJ++;
                curPosI++;
                regulator++;
            }
        }

        // Print Matrix
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                Console.Write("{0,-3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }      
    }
}
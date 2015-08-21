//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        var writer = new StreamWriter("../../result.txt");
        var reader = new StreamReader("../../data.txt");
        int[,] area = ReadInput(reader);

        int maxSum = int.MinValue;

        for (int row = 0; row < area.GetLength(0) - 1; row++)
        {
            int currentSum = 0;
            for (int col = 0; col < area.GetLength(1) - 1; col++)
            {
                currentSum += (area[row, col] + area[row, col + 1] + area[row + 1, col] + area[row + 1, col + 1]);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }
        }

        using (writer)
        {
            writer.WriteLine(maxSum);
        }

        Console.WriteLine("Answer is saved into the file!");
        
    }

    static int[,] ReadInput(StreamReader reader)
    {
        using (reader)
        {
            int n = int.Parse(reader.ReadLine());
            int[,] area = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = reader.ReadLine();
                string[] lineNums = line.Split(' ');
                int[] numArr = new int[lineNums.Length];

                for (int s = 0; s < lineNums.Length; s++)
                {
                    numArr[s] = int.Parse(lineNums[s]);
                }

                for (int j = 0; j < n; j++)
                {
                    area[i, j] = numArr[j];
                }
            }
            return area;
        }
    }
}
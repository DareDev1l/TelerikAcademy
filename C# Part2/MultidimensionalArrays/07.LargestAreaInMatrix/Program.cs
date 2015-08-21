using System;

// Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = 
        {
            {1, 3, 9, 0, 1,	4},
            {2, 3, 1, 0, 4,	4},
            {4, 3, 1, 5, 3,	3},
            {4, 3, 1, 3, 3,	1},
            {2, 3, 3, 3, 1,	1}    // 11 3s
        };


        int maxCounter = 0;
        int resultNum = 0;

        int number=0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                number = arr[i, j];
                Area(arr, i, j, number);
                if (Class1.counter > maxCounter)
                {
                    maxCounter = Class1.counter;
                    resultNum = number;
                }

                Class1.counter = 1;
            }

            
        }

        Console.WriteLine("There are {0} '{1}' in the array connected vertically or horizontally", maxCounter,resultNum);
    }

    static void Area(int[,] arr,int i , int j, int num)
    {
        if (i > arr.GetLength(0) || j > arr.GetLength(1) || i < 0 || j < 0)
        {
            // Out of the array
            return;
        }

        // Right
        if(j+1 < arr.GetLength(1) &&  num == arr[i,j + 1] && num != -1)
        {
            Class1.counter++;
            arr[i, j] = -1;
            Area(arr, i, j + 1, num);

        }
        // Down
        if (i + 1 < arr.GetLength(0) && num == arr[i + 1, j] && num != -1)
        {
            Class1.counter++;
            arr[i, j] = -1;
            Area(arr, i + 1, j, num);
        }
        // Left
        if (j - 1 > 0 && num == arr[i, j - 1] && num != -1)
        {
            Class1.counter++;
            arr[i, j] = -1;
            Area(arr, i, j - 1, num);
        }
        // Top
        if (i - 1 > 0 && num == arr[i - 1, j] && num != -1)
        {
            Class1.counter++;
            arr[i, j] = -1;
            Area(arr, i - 1, j, num);
        }

        return;
    }
}
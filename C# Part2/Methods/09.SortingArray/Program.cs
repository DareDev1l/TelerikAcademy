//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
class Program
{
    static int MaxInt(int[] arr, int startPosition)
    {
        int max = arr[startPosition];
        int index = startPosition;

        for (int i = startPosition; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                index = i;
            }
        }

        return index;
    }

    static void SortArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int max = MaxInt(arr, i);
            int temp = arr[i];
            arr[i] = arr[max];
            arr[max] = temp;
        }
    }

    static void Main()
    {
        int[] arr = { 3, 5, 1, 2, 4, 9, 8, 6, 7 };

        SortArr(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}

using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
//smallest from the rest, move it at the second position, etc.

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 9,1,6,4,3,5,2,8,7 };

        // Loop through first to last element
        for (int i = 0; i < arr.Length; i++)
        {
            int min = arr[i];
            int minIndex = i;

            // Find smallest number in the sublist
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minIndex = j;
                }
            }

            // Change positions of elements
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();

    }
}
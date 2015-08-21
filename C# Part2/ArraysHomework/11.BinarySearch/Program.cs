using System;

// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1,2,5,9,16,25,33,166,351,611,5311,6315,31355,63113,313613 };

        int element = 351; // You can try with any element from the array

        int downBoundary = 0;
        int upBoundary = 14;
        int midBoundary = (downBoundary + upBoundary) / 2;

        if(arr[downBoundary] == element)
        {
            midBoundary = downBoundary;
        }
        else if(arr[upBoundary] == element)
        {
            midBoundary = upBoundary;
        }
        else
        {
            while (downBoundary != upBoundary)
            {
                midBoundary = (downBoundary + upBoundary) / 2;

                if (arr[midBoundary] == element)
                {
                    break;
                }
                else if (element > arr[midBoundary])
                {
                    downBoundary = midBoundary;
                }
                else if (element < arr[midBoundary])
                {
                    upBoundary = midBoundary;
                }
            }
        }
        
        Console.WriteLine("{0} is at position {1}", element, midBoundary);
    }
}

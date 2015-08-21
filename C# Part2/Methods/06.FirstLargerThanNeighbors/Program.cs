//Write a method that returns the index of the first element in array that is
//larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
class Program
{
    static bool LargerThanNeighbors(int[] arr, int position)
    {
        if (position == 0 || position == arr.Length - 1)
        {
            Console.WriteLine("This elements has only 1 neighbour.");
            return false;
        }
        else if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
        {
            return true;
        }
        else return false;
    }

    static void Main(string[] args)
    {
        int[] arr = { 3, 1, 5, 6, 3, 1, 3, 5, 2, 1, 3, 5, 8, 6, 4 };

        for (int i = 1; i < arr.Length-1; i++)
        {
            if(LargerThanNeighbors(arr, i) == true)
            {
                Console.WriteLine("First element bigger than its neighbours: arr[{0}] = {1}", i, arr[i]);
                break;
            }
        }
    }
}
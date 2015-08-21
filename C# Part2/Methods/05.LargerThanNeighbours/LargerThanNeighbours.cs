//Write a method that checks if the element at given position in given array 
//of integers is larger than its two neighbours (when such exist).


using System;
class LargerThanNeighbours
{
    static bool LargerThanNeighbors(int[] arr, int position)
    {
        if(position == 0 || position == arr.Length - 1)
        {
            Console.WriteLine("This elements has only 1 neighbour.");
            return false;
        }
        else if(arr[position] > arr[position-1] && arr[position] > arr[position+1])
        {
            return true;
        }
        else return false;
    }

    static void Main(string[] args)
    {
        int[] arr = { 2, 1, 5, 4,2 };
        Console.WriteLine("{0} is larger than neighbours? - {1}", arr[2], LargerThanNeighbors(arr, 2));
    }
}

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
class CounterNumbers
{
    static int GetNumberOccurance(int[] arr, int number)
    {
        int count = 0;

        foreach (var item in arr)
        {
            if(item == number)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 8 }; // 5 '5's

        Console.WriteLine(GetNumberOccurance(arr, 5));
    }
}
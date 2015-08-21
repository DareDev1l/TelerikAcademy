using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class Program
{
    static void Main(string[] args)
    {
        char[] arr1 = { 'a', 'b', 'c' }; // { 'a', 'c', 'e'}
        char[] arr2 = { 'a', 'b', 'c' }; // { 'a', 'c', 'z'}

        int smaller = 0;
        bool areEqual = true;
        bool equalSize = arr1.Length == arr2.Length;

        if(arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;
        }


        if (areEqual)
        {
            Console.WriteLine("Arrays are lexicographically equal");
        }
        else
        {
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] > arr2[i])
                {
                    equalSize = false;
                    smaller = 2;
                }
                else if (arr2[i] > arr1[i])
                {
                    equalSize = false;
                    smaller = 1;
                }
            }
        }

        if (smaller == 1)
        {
            Console.WriteLine("Array 1 is lexicographically smaller.");
        }
        else if(smaller == 2)
        {
            Console.WriteLine("Array 2 is lexicographically smaller.");
        }

       
        
    }
}
using System;

//You are given an array of strings. Write a method that sorts the array by the
//length of its elements (the number of characters composing them).

class Program
{
    static void Main(string[] args)
    {


        string[] stringArr = {"abc", "a", "abcde", "b", "pie", "telerik academy", "abcdefg", "abcd"};

        // Using bubble sort for the lengths of the strings
        for (int i = 0; i < stringArr.Length; i++)
        {
            int min = stringArr[i].Length;
            int minIndex = i;

            // Find smallest number in the sublist
            for (int j = i; j < stringArr.Length; j++)
            {
                if (stringArr[j].Length < min)
                {
                    min = stringArr[j].Length;
                    minIndex = j;
                }
            }

            // Change positions of elements
            string temp = stringArr[i];
            stringArr[i] = stringArr[minIndex];
            stringArr[minIndex] = temp;
        }

        // Print elements of sorted array on each line
        for (int i = 0; i < stringArr.Length; i++)
        {
            Console.WriteLine(stringArr[i]);
        }
        Console.WriteLine();
    }
}

using System;

//Write a program, that reads from the console an array of N integers
//and an integer K, sorts the array and using the method Array.BinSearch()
//finds the largest number in the array which is ≤ K.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 1 number per row:");

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int ind = Array.BinarySearch(arr,k);
        if (ind < 0)
        {
            ind = ~ind - 1;
        }

        if (arr[0] > k)
        {
            Console.WriteLine("No such integer!");
            return;
        }
        Console.WriteLine("The biggest num <= {1} is: {0}", arr[ind],k);
    }
}
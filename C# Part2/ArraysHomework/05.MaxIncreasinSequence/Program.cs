using System;

//Write a program that finds the maximal increasing sequence in an array.
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 5, 14, 1, 2, 3, 4, 5, 6, 7, 8, 3, 1, 2, 3 }; // 1 to 8
        int maxCounter = 0;
        int maxNum = Int32.MinValue;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int counter = 1;
            int num = arr[i];
            int temp = i;

            while ((temp + 1 <= arr.Length - 1) && arr[temp + 1] == arr[temp] + 1)
            {
                counter++;
                temp++;
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                maxNum = num;
            }
        }

        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write("{0} ", maxNum + i);
        }
        Console.WriteLine();
    }
}
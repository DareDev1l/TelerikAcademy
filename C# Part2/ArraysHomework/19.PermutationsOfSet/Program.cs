using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            list.Add(i);
        }

        List<string> myString = { "a", "b", "c", "d", "f" };
        List<int> result = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < myString.Count; j++)
            {
                if (i == j)
                    continue;
                result.Add(myString[i] + myString[j]);
            }
        }
    }


}
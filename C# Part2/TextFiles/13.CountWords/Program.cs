//Write a program that reads a list of words from the file words.txt and finds how many 
//times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by
//the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.﻿

using System;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            int[] counter = new int[words.Length];

            using (StreamReader wordsCounted = new StreamReader("../../test.txt"))
            {
                string line = wordsCounted.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        counter[i] = counter[i] + Regex.Matches(line, "\\b" + words[i] + "\\b").Count;
                    }
                    line = wordsCounted.ReadLine();
                }
            }
            Array.Sort(counter, words);

            using (StreamWriter counterWords = new StreamWriter("../../result.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    counterWords.WriteLine("{0} -> {1} times", words[i], counter[i]);
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("{0} -> {1} times", exception.GetType().Name, exception.Message);
        }
        Console.WriteLine("Words saved in result.txt");
    }
}
// Write a program that reads a string from the console and prints all different letters
// in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
class Program
{
    static void Info(string text)
    {
        var letters = new List<char>();
        int[] lettersCount = new int[text.Length];
        int counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if(!letters.Contains(text[i]))
            {
                letters.Add(text[i]);
                lettersCount[counter] = 1;
                counter++;
            }
            else
            {
                lettersCount[letters.IndexOf(text[i])]++;
            }
        }

        for (int i = 0; i < letters.Count; i++)
        {
            Console.WriteLine("{0} -> {1}", letters[i], lettersCount[i]);
        }
    }
    static void Main(string[] args)
    {
        string text = "I love telerik academy";
        Info(text);
    }
}
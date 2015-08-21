//Write a program that reads a string from the console and replaces all series of consecutive
// identical letters with a single one.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var letters = new HashSet<char>();

        string text = "aaaaaaaaaabbbbbccccddeeee";
        for (int i = 0; i < text.Length; i++)
        {
            letters.Add(text[i]);
        }

        foreach (char letter in letters)
        {
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}
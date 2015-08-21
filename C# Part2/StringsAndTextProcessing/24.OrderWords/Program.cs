//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Linq;
using System.Collections.Generic;
class Program
{

    static void Main()
    {
        string words = "word another alphabet brother zoo high monday";
        string[] arrWords = words.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        var sorterWords = arrWords.OrderBy(x => x)
                          .ThenBy(x => x.Length)
                          .ToList();

        foreach (var word in sorterWords)
        {
            Console.WriteLine(word);
        }
    }
}

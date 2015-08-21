//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary[".NET"] = "platform for applications from Microsoft";
        dictionary["CLR"] = "managed execution environment for .NET";
        dictionary["namespace"] = "hierarchical organization of classes";

        string word = Console.ReadLine();

        Console.WriteLine(dictionary[word]);
    }
}
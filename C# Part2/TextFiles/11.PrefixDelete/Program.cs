//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static string ReadInput(StreamReader reader)
    {
        string text = reader.ReadToEnd();
        return text;
    }

    static string[] RemoveWord(string[] words , string word)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains("test"))
            {
                words[i] = string.Empty;
            }
        }

        return words;
    }
    static void Main()
    {
        var reader = new StreamReader("../../test.txt");
        string text = reader.ReadToEnd();
        reader.Close();

        string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        string[] result = RemoveWord(words , "test");

        for (int i = 0; i < result.Length; i++)
        {
            if (!(result[i] == string.Empty))
            {
                Console.Write("{0} ", result[i]);
            }
        }
    }
}
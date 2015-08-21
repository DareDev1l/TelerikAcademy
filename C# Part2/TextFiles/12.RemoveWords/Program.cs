//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
class Program
{
    static string[] ReadForbiddenWords(StreamReader reader)
    {
        string input = reader.ReadToEnd();
        reader.Close();

        return input.Split(' ');
    }

    static string[] RemoveWord(string[] words, string word)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(word))
            {
                words[i] = string.Empty;
            }
        }

        return words;
    }

    static void Main()
    {
        // Read forbidden words
        var reader = new StreamReader("../../words.txt");
        var forbiddenWords = ReadForbiddenWords(reader);

        // Read text
        var textReader = new StreamReader("../../text.txt");
        string text = textReader.ReadToEnd();
        var textArr = text.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
        textReader.Close();

        string[] result = RemoveWord(textArr, forbiddenWords[0]);

        // Remove forbidden words
        for (int i = 1; i < forbiddenWords.Length; i++)
		{
			 result = RemoveWord(result, forbiddenWords[i]);
		}

        // Print result
        for (int i = 0; i < result.Length; i++)
        {
            if (!(result[i] == string.Empty))
            {
                Console.Write("{0} ", result[i]);
            }
        }
        Console.WriteLine();
    }

}
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;
class Program
{
    static string ForbidWords(string text, string[] forbiddenWords)
    {
        string result = text;

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            result = result.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        return result;
    }

    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = {"Microsoft", "PHP", "CLR"};

        string result = ForbidWords(text, forbiddenWords);
        Console.WriteLine(result);

    }
}
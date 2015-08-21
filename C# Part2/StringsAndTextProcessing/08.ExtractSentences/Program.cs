//Write a program that extracts from a given text all sentences containing given word.

using System;
class Program
{
    static string Extract(string text , string word)
    {
        string result = string.Empty;
        string[] sentences = text.Split('.');
        string key = " " + word + " ";

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(key) != -1)
            {
                result += sentences[i] + ".";
            }
        }


        return result;
    }
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        string result = Extract(text, word);
        Console.WriteLine(result);
    }
}
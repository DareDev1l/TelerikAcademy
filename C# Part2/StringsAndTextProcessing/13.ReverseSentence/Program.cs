//Write a program that reverses the words in given sentence.

using System;

class Program
{
    static string ReverseString(string input)
    {
        string result = string.Empty;
        char[] symbols = new char[input.Length / 2];
        int[] indeces = new int[symbols.Length];
        int counter = 0;

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            result += words[i] + " ";
        }


        return result;
    }
    static void Main(string[] args)
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(ReverseString(input));
    }
}
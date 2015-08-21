//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;
class Program
{
    static bool IsPolindrome(string word)
    {
        bool isPalindrome = true;

        for (int i = 0; i < word.Length; i++)
        {
            if(word[i] != word[word.Length - i - 1])
            {
                isPalindrome = false;
            }
        }

        return isPalindrome;
    }
    static void Main()
    {
        string text = "Palindromes are words like these : ABBA , lamal , exe";
        string[] words = text.Split(new char[] {' ' , ',' , ':'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (IsPolindrome(word))
            {
                Console.WriteLine(word);
            }
        }
    }
}
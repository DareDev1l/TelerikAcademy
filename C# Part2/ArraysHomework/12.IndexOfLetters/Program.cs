using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray();
        char[] word = Console.ReadLine().ToUpper().ToCharArray();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if(word[i] == alphabet[j])
                {
                    Console.Write("{0} ",j);
                }
            }
        }
    }
}
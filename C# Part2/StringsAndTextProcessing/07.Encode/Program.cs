//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
class Program
{
    static string Encode(string input, string cipher)
    {
        char[] inputChars = input.ToCharArray();
        char[] cipherChars = cipher.ToCharArray();
        char[] resultChars = new char[inputChars.Length];

        for (int i = 0; i < inputChars.Length; i++)
        {
            resultChars[i] = (char)(inputChars[i] ^ cipherChars[i % cipherChars.Length]); 
        }

        string encoded = string.Empty;

        for (int i = 0; i < resultChars.Length; i++)
        {
            encoded += resultChars[i];
        }

        return encoded;
    }

    static void Main()
    {
        string input = "TelerikAcademy";
        string cipher = "KEY";

        string encodedInput = Encode(input, cipher);
        Console.WriteLine(encodedInput);
    }
}
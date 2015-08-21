using System;
using System.Text;

// Write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
// Note: Some characters have a special purpose and will not be displayed as expected. You may SKIP them!!!!!
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
        for (int i = 0; i < 255; i++)
        {
            if (!char.IsControl((char)i))
                Console.WriteLine((char)i);
        }

    }
}
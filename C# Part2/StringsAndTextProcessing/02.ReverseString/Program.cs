// Write a program that reads a string, reverses it and prints the result at the console.

using System;
class Program
{
    static string Reverse(string str)
    {
        string reversed = String.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }


        return reversed;
    }

    static void Main()
    {
        Console.Write("Enter a string to be reversed: ");
        string input = Console.ReadLine();
        Console.WriteLine(Reverse(input));
    }
}
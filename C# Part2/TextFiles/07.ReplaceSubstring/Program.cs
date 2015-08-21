//Write a program that replaces all occurrences of the sub-string start 
//with the sub-string finish in a text file.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../input.txt");
        var writer = new StreamWriter("../../output.txt");

        string text = reader.ReadToEnd();
        reader.Close();
        string replacedText = text.Replace("start", "finish");

        using (writer)
        {
            writer.WriteLine(replacedText);
        }

        Console.WriteLine("start replaced with finish");
    }
}

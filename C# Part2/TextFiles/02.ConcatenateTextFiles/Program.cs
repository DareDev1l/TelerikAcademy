// Write a program that concatenates two text files into another text file.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader text1 = new StreamReader("../../file1.txt");
        string line = text1.ReadToEnd();
        text1.Close();
        StreamReader text2 = new StreamReader("../../file2.txt");
        string line2 = text2.ReadToEnd();
        text2.Close();

        StreamWriter result = new StreamWriter("../../result.txt");
        result.WriteLine(line + line2);
        result.Close();
        
    }
}
// Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../firstFile.txt");
        var writer = new StreamWriter("../../result.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            int lineNumber = 1;

            using (writer)
            {
                while (line != null)
                {
                    writer.WriteLine("{0}. {1}", lineNumber, line);
                    lineNumber++;
                    line = reader.ReadLine();
                } 
            }
        }
        Console.WriteLine("Done");
    }
}
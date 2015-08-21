// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../file.txt");

        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }

        }
    }
}
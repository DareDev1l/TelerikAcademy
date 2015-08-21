//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../file.txt");
        var list = new List<string>();

        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        list.Add(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
        }
        var writer = new StreamWriter("../../file.txt");
        using (writer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
            }
        }
    }

}
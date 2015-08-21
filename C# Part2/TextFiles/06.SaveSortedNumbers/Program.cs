//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../names.txt");
        var names = ReadInput(reader);
        var writer = new StreamWriter("../../result.txt");

        using (writer)
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }
        Console.WriteLine("Names sorted and saved into result.txt");
    }

    static List<string> ReadInput(StreamReader reader)
    {
       

        var words = new List<String>();

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                words.Add(line);
                line = reader.ReadLine();
            }
        }

        List<string> sorted = words.OrderBy(x => x).ToList();

        return sorted;
    }
}
//Write a program that extracts from given XML file all the text without the tags

using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static string Extrat(string HTMLText)
    {
        Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
        return reg.Replace(HTMLText, "");
    }

    static void Main()
    {
        var reader = new StreamReader("../../xml.txt");
        string xml = reader.ReadToEnd();
        reader.Close();

        Console.WriteLine(Extrat(xml));
    }
}


//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main()
    {
        string input = "My best friend's email address is goshozeleniq@yahoo.com . My email address is hisbrother@gmail.com";
        string pattern = @"(\w+)@([a-zA-Z0-9_\-\.]+)\.[a-zA-Z]{2,3}";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
        {
            Console.WriteLine(matches[i]);
        }

        if (matches.Count == 0)
        {
            Console.WriteLine("No matches");
        }
    }
}
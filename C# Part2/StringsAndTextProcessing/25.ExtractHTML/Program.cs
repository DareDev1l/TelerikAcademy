// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text.RegularExpressions;
class Program
{
    static string Extrat(string HTMLText)
    {
        Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
        return reg.Replace(HTMLText, "");
    }
    static void Main(string[] args)
    {
        string html = @"
<html><head><title>News</title>
</head>
<body><p><a href=""http://academy.telerik.com"">Telerik Academy </a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p>
</body>
</html>";

            Console.WriteLine(Extrat(html));
    }
}
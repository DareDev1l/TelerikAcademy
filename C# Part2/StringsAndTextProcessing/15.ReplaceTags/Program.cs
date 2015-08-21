// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
    class Program
    {
        static string ReplaceTags(string input)
        {
            string result = string.Empty;
            result += input.Replace("<a href", "[URL").Replace("</a>", "[/URL]");

            return result;
        }
        static void Main(string[] args)
        {
            string input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose
a training course. Also visit <a href=""www.devbg.org"">our
forum</a> to discuss the courses.</p>";
            Console.WriteLine(ReplaceTags(input));
        }
    }

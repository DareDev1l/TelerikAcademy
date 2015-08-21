//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LongestString
    {
        static void Main()
        {
            string[] words = new string[]
            {
                "Pesho",
                "Gosho",
                "Mnogo Dulgo Izrechenie",
                "Nqkakvi drugi",
                "b",
                "abc"
            };

            var longestString =
                (from word in words
                orderby word.Length descending
                select word).First();

            Console.WriteLine(longestString);
        }
    }
}

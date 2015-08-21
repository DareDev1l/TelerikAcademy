// Write a program that reads a string from the console and lists all different words
// in the string along with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class Program
    {
        static void Info(string[] text)
        {
            var words = new List<string>();
            int[] wordsCount = new int[text.Length];
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (!words.Contains(text[i]))
                {
                    words.Add(text[i]);
                    wordsCount[counter] = 1;
                    counter++;
                }
                else
                {
                    wordsCount[words.IndexOf(text[i])]++;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", words[i], wordsCount[i]);
            }
        }
        static void Main(string[] args)
        {
            string text = "To understand recursion , you mmust first understand recursion!";
            string[] words = text.Split(new char[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Info(words);
        }
    }
}

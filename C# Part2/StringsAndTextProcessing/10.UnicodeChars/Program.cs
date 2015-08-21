// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Text;
class Program
{
    static string ToUnicode(string input)
    {
        string toUnicode = string.Empty;
        byte[] inputArr = Encoding.Unicode.GetBytes(input);
        
            foreach (byte item in inputArr)
            {
                string rightSide = item.ToString("X").PadLeft(4, '0');
                toUnicode += string.Format("{0}{1}", @"\u", rightSide);
            }

        return toUnicode;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ToUnicode(input));

    }
}

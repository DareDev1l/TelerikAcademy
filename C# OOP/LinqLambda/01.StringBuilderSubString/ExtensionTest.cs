//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace _01.StringBuilderSubString
{
    using System;
    using System.Text;

    public class ExtensionTest
    {
        static void Main()
        {
            StringBuilder testWord = new StringBuilder();

            testWord.Append("MnogoDulgaDuma");

            StringBuilder result = testWord.Substring(5, 9);

            Console.WriteLine(result.ToString());
        }
    }
}

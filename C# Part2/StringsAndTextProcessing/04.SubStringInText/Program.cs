//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
class Program
{
    static int SubstringInText(string text, string subStr)
    {
        int count = 0;
        int curPosition = 0;

        while(true)
        {
            if(text.IndexOf(subStr, curPosition) == -1)
            {
                break;
            }
            count++;
            curPosition = text.IndexOf(subStr, curPosition) + 1;
        }

        return count;
    }
    static void Main()
    {
        // There are 9 "in" in the text
        string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(SubstringInText(text, "in"));
        
    }
}
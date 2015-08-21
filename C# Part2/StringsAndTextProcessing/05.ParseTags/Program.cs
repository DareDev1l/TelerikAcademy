//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Collections.Generic;
class Program
{
    static int SubstringInText(string text, string subStr)
    {
        int count = 0;
        int curPosition = 0;

        while (true)
        {
            if (text.IndexOf(subStr, curPosition) == -1)
            {
                break;
            }
            count++;
            curPosition = text.IndexOf(subStr, curPosition) + 1;
        }

        return count;
    }

    static string findUpcase(string text)
    {
        char[] result = text.ToCharArray();

        int curStart = text.IndexOf("<upcase>", 0);
        int curEnd = text.IndexOf("</upcase>", 0);

        while (true)
        {
            if(curStart == -1 || curEnd == -1)
            {
                break;
            }
            for (int i = curStart; i < curEnd; i++)
            {
                if(result[i] >= 'a' && result[i] <= 'z')
                {
                    result[i] = (char)(result[i] - 32);
                }
            }

            curStart = text.IndexOf("<upcase>", curStart + 1);
            curEnd = text.IndexOf("</upcase>", curEnd + 1);
        }

        string resultString = string.Empty;
        for (int i = 0; i < result.Length; i++)
        {
            resultString += result[i];
        }


        return resultString;
    }

    static string RemoveUpcase(string input)
    {
        string result = input;
        int position = 0;

        while (true)
        {
            position = result.IndexOf("<UPCASE>");
            if(position == -1)
            {
                break;
            }

            result = result.Remove(position, 8);
            position++;
        }

        while (true)
        {
            position = result.IndexOf("</upcase>");
            if (position == -1)
            {
                break;
            }

            result = result.Remove(position, 9);
            position++;
        }

        return result;
    }

    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string result = findUpcase(text);
        string finalResult = RemoveUpcase(result);
        Console.WriteLine(finalResult);
    }
}
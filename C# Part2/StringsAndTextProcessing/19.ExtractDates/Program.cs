//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Threading;

class DatesInCanada
{
    static void Main()
    {
        string text = "Pesho was born on 29.02.2000 and since then he celebrated his birthday only 3 times. That is sad because if only he came out on 28.02.2000 he would be one happy child.";
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        CanadaDateFormat(TrimWords(words));
    }

    private static void CanadaDateFormat(string[] words)
    {
        foreach (string word in words)
        {
            DateTime newDateTime = new DateTime();

            if (DateTime.TryParseExact(word, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                Console.WriteLine(newDateTime.Date.ToShortDateString());
            }
        }
    }

    private static string[] TrimWords(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].TrimStart('.');
            words[i] = words[i].TrimEnd('.');
        }

        return words;
    }
}

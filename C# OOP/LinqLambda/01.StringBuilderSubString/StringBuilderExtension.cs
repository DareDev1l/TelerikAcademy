namespace _01.StringBuilderSubString
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);

            string word = stringBuilder.ToString();

            for (int i = index; i < index + length; i++)
            {
                result.Append(word[i]);
            }

            return result;
        }

    }
}

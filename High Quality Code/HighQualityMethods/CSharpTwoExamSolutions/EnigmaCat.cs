namespace EnigmaCat
{
    using System;

    public class EnigmaCat
    {
        public static void Solve()
        {
            char[] hashMap = InitializeHashMap();

            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            string[] result = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                result[i] = Base10ToBase26(Base16to10(words[i]), hashMap);
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }

        public static double Base16to10(string word)
        {
            double result = 0;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                double power = Math.Pow(17.0, (double)(word.Length - i - 1));
                double charKeyCode = (double)(word[i] - 'a');

                result += charKeyCode * power;
            }

            return result;
        }

        public static string Base10ToBase26(double numberInDecimal, char[] base26HashMap)
        {
            string base26Word = string.Empty;

            if (numberInDecimal == 0)
            {
                return "a";
            }

            while (numberInDecimal != 0)
            {
                int hashMapKey = (int)(numberInDecimal % 26);
                base26Word = base26HashMap[hashMapKey] + base26Word;
                numberInDecimal = numberInDecimal / 26;
            }

            return base26Word;
        }

        public static char[] InitializeHashMap()
        {
            char[] hashMap = new char[26];

            for (int i = 0; i < 26; i++)
            {
                hashMap[i] = (char)('a' + i);
            }

            return hashMap;
        }
    }
}

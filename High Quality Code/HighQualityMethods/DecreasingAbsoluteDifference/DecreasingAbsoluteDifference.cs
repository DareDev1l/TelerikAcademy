namespace DecreasingAbsoluteDifference
{
    using System;

    public class DecreasingAbsoluteDifference
    {
        public static void Solve()
        {
            long inputAsLong = long.Parse(Console.ReadLine());

            for (long count = 0; count < inputAsLong; count++)
            {
                string line = Console.ReadLine();

                string[] numsAsStrings = line.Split(' ');

                long[] numbersOnCurrentLine = ParseNumbers(numsAsStrings);

                long[] sequence = GetSequence(numbersOnCurrentLine);

                bool isValidSequence = IsValidSequence(sequence);

                Console.WriteLine(isValidSequence);
            }
        }

        public static long AbsoluteDifference(long a, long b)
        {
            return Math.Abs(a - b);
        }

        public static long[] ParseNumbers(string[] numbersAsStrings)
        {
            long[] numbers = new long[numbersAsStrings.Length];

            for (long i = 0; i < numbersAsStrings.Length; i++)
            {
                numbers[i] = long.Parse(numbersAsStrings[i]);
            }

            return numbers;
        }

        public static long[] GetSequence(long[] numbers)
        {
            long[] sequence = new long[numbers.Length - 1];
            
            for (long i = 0; i < numbers.Length - 1; i++)
            {
                sequence[i] = AbsoluteDifference(numbers[i], numbers[i + 1]);
            }

            return sequence;
        }

        public static bool IsValidSequence(long[] sequence)
        {
            bool isValid = true;

            for (long i = 0; i < sequence.Length - 1; i++)
            {
                if (!(sequence[i] >= sequence[i + 1] && (AbsoluteDifference(sequence[i], sequence[i + 1]) == 0 || AbsoluteDifference(sequence[i], sequence[i + 1]) == 1)))
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}

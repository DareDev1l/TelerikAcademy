namespace Methods
{
    using System;

    public static class PrintUtils
    {
        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentOutOfRangeException("Parameter should be a digit between 0 and 9");
            }
        }

        public static void PrintAsNumber(object number, PrintFormat format)
        {
            switch (format)
            {
                case PrintFormat.DoublePrecision:
                    Console.WriteLine("{0:f2}", number);
                    break;

                case PrintFormat.Percentage:
                    Console.WriteLine("{0:p0}", number);
                    break;

                case PrintFormat.Right:
                    Console.WriteLine("{0,8}", number);
                    break;

                default:
                    throw new ArgumentException("Format parameter should be a valid PrintFormat enum");
            }
        }
    }
}

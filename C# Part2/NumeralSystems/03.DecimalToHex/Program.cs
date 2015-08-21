// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
class Program
{   
    static char[] DecimalToHex(long number)
    {
        string digit = String.Empty;
        string hexNumber = String.Empty;

        while (number != 0)
        {
            digit = (number % 16).ToString();
            switch (digit)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    hexNumber += digit;
                    break;
                case "10":
                    hexNumber += "A";
                    break;
                case "11":
                    hexNumber += "B";
                    break;
                case "12":
                    hexNumber += "C";
                    break;
                case "13":
                    hexNumber += "D";
                    break;
                case "14":
                    hexNumber += "E";
                    break;
                case "15":
                    hexNumber += "F";
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            number = number / 16;
        }
        char[] reversed = hexNumber.ToCharArray();
        Array.Reverse(reversed);
        return reversed;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHex(n));
    }
}

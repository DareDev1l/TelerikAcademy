// Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;
class Program
{
    static int BinaryToDecimal(string input)
    {

        int numberInDecimal = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int bit = (int)(input[i] - '0');
            numberInDecimal += (int)(Math.Pow(2.0, (double)input.Length - i - 1)) * bit;
        }
        return numberInDecimal;
    }

    static string DecimalToHex(long number)
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
        string result = string.Empty;
        for (int i = 0; i < reversed.Length; i++)
        {
            result += reversed[i];
        }
        return result;
    }

    static string BinaryToHexadecimal(string input)
    {
        string hex = String.Empty;

        for (int i = 0; i < input.Length; i += 4)
        {
            string fourDigits = String.Empty;
            for (int j = i; j < i+4; j++)
            {
                fourDigits += input[j];
            }
            int num = BinaryToDecimal(fourDigits);
            fourDigits = DecimalToHex(num);
            hex += fourDigits;
        }
        
        return hex;
    }

    static void Main()
    {
        // 1111 - F
        // 0101 - 5
        // 0111 - 7
        // 11   - 3
        // You can try with 32 bits if you want to check
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        string result = binary.PadLeft((32 - binary.Length) % 4 + binary.Length, '0');
        Console.WriteLine(BinaryToHexadecimal(result));
    }
}
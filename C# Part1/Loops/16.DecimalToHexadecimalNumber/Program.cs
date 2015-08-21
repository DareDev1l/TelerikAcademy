using System;

// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

class Program
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        string digit = String.Empty;
        string hexNumber = String.Empty;

        while (number != 0)
        {
            digit = (number % 16).ToString();
            switch(digit)
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
        Console.WriteLine(reversed);
    }
    
}
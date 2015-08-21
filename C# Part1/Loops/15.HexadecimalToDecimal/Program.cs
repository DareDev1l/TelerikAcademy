using System;

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        ulong number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= '0' && input[i] <= '9')
            {
                number += (ulong)(input[i] - '0') * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1)); 
            }
            else
            {
                switch(input[i])
                {
                    case 'A':
                        number += 10 * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1));
                        break;
                    case 'B':
                        number += 11 * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1));
                        break;
                    case 'C':
                        number += 12 * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1));
                        break;
                    case 'D':
                        number += 13 * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1));
                        break;
                    case 'E':
                        number += 14 * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1));
                        break;
                    case 'F':
                        number += 15 * (ulong)Math.Pow(16.0, (double)(input.Length - i - 1));
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
        Console.WriteLine(number);
    }
}

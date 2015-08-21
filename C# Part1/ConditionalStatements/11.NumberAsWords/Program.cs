using System;

// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation

class Program
{
    public static void printNumberAsWord(int a, int b, int c)
    {
        switch (a)
        {
            case 0: Console.Write(""); break;
            case 1: Console.Write("One hundred "); break;
            case 2: Console.Write("Two hundred "); break;
            case 3: Console.Write("Three hundred "); break;
            case 4: Console.Write("Four hundred "); break;
            case 5: Console.Write("Five hundred "); break;
            case 6: Console.Write("Six hundred "); break;
            case 7: Console.Write("Seven hundred "); break;
            case 8: Console.Write("Eight hundred "); break;
            case 9: Console.Write("Nine hundred "); break;
            default: Console.Write("Number should be in the range [0...999]"); break;
        }
        switch (b)
        {
            case 0: Console.Write("and "); break;
            case 2: Console.Write("and  twenty "); break;
            case 3: Console.Write("and thirty "); break;
            case 4: Console.Write("and forty "); break;
            case 5: Console.Write("and fifty "); break;
            case 6: Console.Write("and sixty "); break;
            case 7: Console.Write("and seventy "); break;
            case 8: Console.Write("and eighty "); break;
            case 9: Console.Write("and ninety "); break;
            default: Console.Write("Number should be in the range [0...999]"); break;
        }
        switch (c)
        {
            case 0: Console.Write(""); break;
            case 1: Console.Write("one"); break;
            case 2: Console.Write("two"); break;
            case 3: Console.Write("three"); break;
            case 4: Console.Write("four"); break;
            case 5: Console.Write("five"); break;
            case 6: Console.Write("six"); break;
            case 7: Console.Write("seven"); break;
            case 8: Console.Write("eight"); break;
            case 9: Console.Write("nine"); break;
            case 10: Console.Write("ten"); break;
            case 11: Console.Write("eleven"); break;
            case 12: Console.Write("twelve"); break;
            case 13: Console.Write("thirteen"); break;
            case 14: Console.Write("fourteen"); break;
            case 15: Console.Write("fifteen"); break;
            case 16: Console.Write("sixteen"); break;
            case 17: Console.Write("seventeen"); break;
            case 18: Console.Write("eighteen"); break;
            case 19: Console.Write("nineteen"); break;
            default: Console.Write("Number should be in the range [0...999]"); break;
        }
    }
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int a = number / 100;       // first digit
        int b = (number / 10) % 10;   // second digit
        int c = number % 10;       // third digit

        // if number's last numbers are not between 10 and 19 , use a,b,c as parameters
        if (b != 1)
        {
            printNumberAsWord(a, b, c);
            Console.WriteLine();
        }
        // if number's last numbers are between 10 and 19 , use a , 0, c + 10 as parameters
        // so we can print values properly
        else
        {
            printNumberAsWord(a, 0, c + 10);
            Console.WriteLine();
        }
    }
}

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] polynomialFirst = { 4,1,2 };
        int[] polynomiralSecond = { 2, 3 };

        Console.WriteLine("Sum:");
        OutputPolynomial(polynomialFirst);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" + ");
        Console.ResetColor();
        OutputPolynomial(polynomiralSecond);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" = ");
        Console.ResetColor();
        OutputPolynomial(Sum(polynomialFirst, polynomiralSecond));
        Console.WriteLine();

        Console.WriteLine("Subtraction");
        OutputPolynomial(polynomialFirst);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" - ");
        Console.ResetColor();
        OutputPolynomial(polynomiralSecond);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" = ");
        Console.ResetColor();
        OutputPolynomial(Subtract(polynomialFirst, polynomiralSecond));
        Console.WriteLine();

        Console.WriteLine("Multiplication");
        OutputPolynomial(polynomialFirst);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" * ");
        Console.ResetColor();
        OutputPolynomial(polynomiralSecond);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" = ");
        Console.ResetColor();
        OutputPolynomial(Multiply(polynomialFirst, polynomiralSecond));
        Console.WriteLine();

    }

    static int[] Subtract(int[] polynomialFirst, int[] polynomialSecond)
    {
        int maxLength = Math.Max(polynomialFirst.Length, polynomialSecond.Length);
        int minLength = Math.Min(polynomialFirst.Length, polynomialSecond.Length);
        int[] res = new int[maxLength];

        for (int i = 0; i < minLength; i++)
        {
            res[i] = polynomialFirst[i] - polynomialSecond[i];
        }

        if (maxLength != minLength)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                res[i] = (polynomialFirst.Length == maxLength) ? polynomialFirst[i] : polynomialSecond[i];
            }
        }

        return res;
    }

    static int[] Sum(int[] polynomialFirst, int[] polynomialSecond)
    {
        int maxLength = Math.Max(polynomialFirst.Length, polynomialSecond.Length);
        int minLength = Math.Min(polynomialFirst.Length, polynomialSecond.Length);
        int[] res = new int[maxLength];

        for (int i = 0; i < minLength; i++)
        {
            res[i] = polynomialFirst[i] + polynomialSecond[i];
        }

        if (maxLength != minLength)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                res[i] = (polynomialFirst.Length == maxLength) ? polynomialFirst[i] : polynomialSecond[i];
            }
        }

        return res;
    }

    static int[] Multiply(int[] polynomialFirst, int[] polynomialSecond)
    {
        int[] result = new int[polynomialFirst.Length + polynomialSecond.Length - 1];

        for (int i = 0; i < polynomialFirst.Length; i++)
        {
            for (int j = 0; j < polynomialSecond.Length; j++)
            {
                result[i + j] += (polynomialFirst[i] * polynomialSecond[j]);

            }
        }

        return result;
    }

    static void OutputPolynomial(int[] polynomial)
    {
        for (int i = 0; i < polynomial.Length; i++)
        {
            Console.Write(polynomial[i] + " * x^" + i);
            if (i < polynomial.Length - 1)
            {
                Console.Write(" + ");
            }
        }
    }
}
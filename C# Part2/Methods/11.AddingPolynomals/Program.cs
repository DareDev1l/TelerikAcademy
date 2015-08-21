//Problem 11. Adding polynomials
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] polynomialFirst = { 2, 5, 14 };
        int[] polynomiralSecond = { 6, 3 };

        OutputPolynomial(polynomialFirst);
        Console.Write(" + ");
        OutputPolynomial(polynomiralSecond);
        Console.Write(" = ");
        OutputPolynomial(Sum(polynomialFirst, polynomiralSecond));
        Console.WriteLine();

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
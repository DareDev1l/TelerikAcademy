//Write a program that can solve these tasks:
//  Reverses the digits of a number
//  Calculates the average of a sequence of integers
//  Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//  The decimal number should be non-negative
//  The sequence should not be empty
//  a should not be equal to 0


using System;
using System.Collections.Generic;
class SolveTasks
{
    static decimal ReverseNumber(decimal num)
    {
        char[] numChars = num.ToString().ToCharArray();
        Array.Reverse(numChars);

        string reversedNum = String.Empty;

        for (int i = 0; i < numChars.Length; i++)
        {
            reversedNum += numChars[i];
        }

        return decimal.Parse(reversedNum);
    }

    static decimal AverageInSequence(List<int> arr)
    {
        int sum = 0;
        decimal average = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
        }

        average = (decimal)(sum) / arr.Count;

        return average;
    }

    static decimal SolveLinearEquation(decimal a, decimal b)
    {
        decimal x = -b / (decimal)a;

        return x;
    }

    static void Main()
    {
        Console.WriteLine("Choose option: \n1.Reverse digits of a number \n2.Calculate the average of sequence" +
        "of integers. \n3.Solve linear equation");

        int input = int.Parse(Console.ReadLine());

        if(input == 1)
        {
            Console.WriteLine("Enter number to reverse: ");
            decimal num = decimal.Parse(Console.ReadLine());
            if(num < 0)
            {
                Console.WriteLine("Invalid input! Closing program...");
                return;
            }
            Console.WriteLine(ReverseNumber(num));
        }
        else if(input == 2)
        {
            int j = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Enter sequence of integers , each one on a new line(0 is accepted as end of input):");
            while (true)
            {
                int inp = int.Parse(Console.ReadLine());
                if(inp == 0)
                {
                    break;
                }
                list.Add(inp);
            }

            if(list.Count == 0)
            {
                Console.WriteLine("Sequence is empty! Closing program...");
            }
            else
            {
                Console.WriteLine("{0:F2}", AverageInSequence(list));
            }
        }
        else if(input == 3)
        {
            Console.WriteLine("a*x + b = 0");
            Console.Write("a = ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("b = ");
            decimal b = decimal.Parse(Console.ReadLine());

            if(a == 0)
            {
                Console.WriteLine("Invalid input! Closing program...");
                return;
            }
            else
            {
                Console.WriteLine("x = {0}", SolveLinearEquation(a, b));
            }
        }
     
    }
}
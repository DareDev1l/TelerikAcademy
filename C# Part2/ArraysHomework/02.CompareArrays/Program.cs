// Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first array with spaces: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter second array with spaces: ");
        string input2 = Console.ReadLine();

        string[] stringArr1 = input1.Split(' ');
        string[] stringArr2 = input2.Split(' ');

        int count;

        if (stringArr1.Length > stringArr2.Length)
        {
            count = stringArr1.Length;
        }
        else
        {
            count = stringArr2.Length;
        }

        for (int i = 0; i < count; i++)
		{
			
                if(int.Parse(stringArr1[i]) > int.Parse(stringArr2[i]))
                {
                    Console.WriteLine("{0} > {1}", stringArr1[i], stringArr2[i]);
                }
                else if (int.Parse(stringArr1[i]) < int.Parse(stringArr2[i]))
                {
                    Console.WriteLine("{0} < {1}", stringArr1[i], stringArr2[i]);
                }
                else if (int.Parse(stringArr1[i]) == int.Parse(stringArr2[i]))
                {
                    Console.WriteLine("{0} = {1}", stringArr1[i], stringArr2[i]);
                }
		}


    }
}
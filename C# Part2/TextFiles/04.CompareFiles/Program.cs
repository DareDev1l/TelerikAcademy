//Write a program that compares two text files line by line and 
//prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader file1 = new StreamReader("../../file1.txt");
        StreamReader file2 = new StreamReader("../../file2.txt");

        int same = 0;
        int different = 0;

        using (file1)
        {
            using (file2)
            {
                string line1 = file1.ReadLine();
                string line2 = file2.ReadLine();

                while (line1 != null)
	            {
	                if(line1 == line2)
                    {
                        same++;
                    }
                    else
                    {
                        different++;
                    }
                    line1 = file1.ReadLine();
                    line2 = file2.ReadLine();
	            }
            }
        }

        Console.WriteLine("Number of same lines: {0}", same);
        Console.WriteLine("Number of different lines: {0}", different);
    }
}
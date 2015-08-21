using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstNum = 0;
        int secondNum = 1;
        int nextNum;

        if (n == 1)
            Console.WriteLine("0");
        else if (n == 0)
            Console.WriteLine("No values!");
        else if (n < 0)
            Console.WriteLine("Invalid argument!");
        else
        {
            Console.Write("{0}, {1}", firstNum, secondNum);

            for (int i = 0; i < n - 2; i++)
            {
                int temp = secondNum;
                secondNum = firstNum + secondNum;
                firstNum = temp;

                Console.Write(", {0}", secondNum);
            }
            Console.WriteLine();
        }
    }
}
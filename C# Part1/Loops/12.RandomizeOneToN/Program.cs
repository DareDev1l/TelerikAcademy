using System;

// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n+1];

        for (int i = 1; i <= n; i++)
        {
            numbers[i] = i;   
        }

        while (n > 1)
        {
                int k = random.Next(n);
                if (k != 0)
                {
                    n--;
                    int temp = numbers[n];
                    numbers[n] = numbers[k];
                    numbers[k] = temp;  
                }
           
        }

        for (int i = 1; i <= numbers.Length - 1; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();
    }
}
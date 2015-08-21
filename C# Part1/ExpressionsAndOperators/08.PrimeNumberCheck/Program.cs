using System;

// Write an expression that checks if given positive integer number n (n = 100) is prime 
// (i.e. it is divisible without remainder only to itself and 1).

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine("{0} is prime ? - {1}", number,  isPrime);

        }
    }
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.DivisibleBy3And7
{
    using System;
    using System.Linq;
    class Divisible
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 6, 3, 1, 3, 7, 21, 64, 4, 15, 11 ,42, 63};

            var divisible = numbers.Where(x => x % 21 == 0).ToList();

            foreach (var num in divisible)
            {
                Console.WriteLine(num);
            }

            // Linq variant

            var divisibleLinq =
                from num in numbers
                where num % 21 == 0
                select num;
        }
    }
}

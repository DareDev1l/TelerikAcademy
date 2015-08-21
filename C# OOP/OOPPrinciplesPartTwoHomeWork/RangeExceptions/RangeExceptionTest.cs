using System;
namespace RangeExceptions
{
    class RangeExceptionTest
    {
        static void Main()
        {
            // If you enter number bigger than 100 or less than 1 , it throws the custom exception
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new RangeException<int>(1, 100);
            }

            DateTime date = new DateTime(2050, 5, 7);

            if (date.Year > 2015 || date.Year < 1980)
            {
                throw new RangeException<DateTime>(new DateTime(1980, 1, 1), new DateTime(2015, 4, 1));
            }
        }
    }
}

namespace LoopRefactor
{
    using System;

    public class Loop
    {
        static void Main()
        {
            int[] numbers = new int[12] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            int expectedValue = 7;
            bool foundValue = false;

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(numbers[i]);

                if (numbers[i] == expectedValue)
                {
                    foundValue = true;
                    break;
                }
            }

            if (foundValue)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

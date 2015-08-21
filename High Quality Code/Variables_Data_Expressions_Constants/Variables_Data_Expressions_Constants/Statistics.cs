namespace Variables_Data_Expressions_Constants
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = arr[0];
            for (int i = 1; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);

            double min = arr[0];
            for (int i = 1; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            double averageValue = sum / count;

            Console.WriteLine(averageValue);
        }
    }
}

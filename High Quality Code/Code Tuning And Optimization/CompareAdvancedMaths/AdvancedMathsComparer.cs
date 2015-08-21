namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class AdvancedMathsComparer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square root performance check\n");
            SqrtPerformanceCheck();
            Console.WriteLine("--------------------------");

            Console.WriteLine("Log performance check\n");
            LogPerformanceCheck();
            Console.WriteLine("--------------------------");

            Console.WriteLine("Sin performance check\n");
            SinPerformanceCheck();
            Console.WriteLine("--------------------------");
        }
        
        private static void SqrtPerformanceCheck()
        {
            Console.WriteLine("Float");

            float floatNumber = 8.5f;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Sqrt((double)floatNumber);
                }
            });

            Console.WriteLine("Double");

            double doulbeNumber = 8.5;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Sqrt(doulbeNumber);
                }
            });

            Console.WriteLine("Decimal");

            decimal decimalNumber = 8.5m;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Sqrt((double)decimalNumber);
                }
            });
        }

        private static void LogPerformanceCheck()
        {
            Console.WriteLine("Float");

            float floatNumber = 8.5f;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Log((double)floatNumber);
                }
            });

            Console.WriteLine("Double");

            double doulbeNumber = 8.5;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Log(doulbeNumber);
                }
            });

            Console.WriteLine("Decimal");

            decimal decimalNumber = 8.5m;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Log((double)decimalNumber);
                }
            });
        }

        private static void SinPerformanceCheck()
        {
            Console.WriteLine("Float");

            float floatNumber = 8.5f;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Sin((double)floatNumber);
                }
            });

            Console.WriteLine("Double");

            double doulbeNumber = 8.5;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Sin(doulbeNumber);
                }
            });

            Console.WriteLine("Decimal");

            decimal decimalNumber = 8.5m;

            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Math.Sin((double)decimalNumber);
                }
            });
        }

        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed + "\n");
        }
    }
}

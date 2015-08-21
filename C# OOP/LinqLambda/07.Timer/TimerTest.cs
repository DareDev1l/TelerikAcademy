//Using delegates write a class Timer that can execute certain method at each t seconds.

namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class TimerTest
    {
        public delegate void ExecMethod(int number);
        static void Main()
        {
            Console.Write("Period of seconds = ");
            int seconds = int.Parse(Console.ReadLine());
            Console.Write("Enter the count of numbers = ");
            int number = int.Parse(Console.ReadLine());

            ExecMethod exec = new ExecMethod(Counter);

            for (int i = 1; i <= number; i++)
            {
                exec(i);
                Thread.Sleep(1000 * seconds);
            }
        }
        public static void Counter(int x)
        {
            Console.Write("{0} ", x);
        }
            
    }
}

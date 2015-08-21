namespace Methods
{
    using System;

    public class CalcUtils
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive numbers");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentOutOfRangeException("The sum of each two sides must be bigger than the third");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("Elements parameter should be a non-empty array");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }
    }
}

using System;

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInsideCircle = ((x-1) * (x-1) + (y-1) * (y - 1)) <= 2.25;
            bool isInsideRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            bool insideCircleOutsideRectangle = isInsideCircle && (!isInsideRectangle);

            Console.WriteLine("Is ({0};{1}) inside circle and outside rectangle ? - {2}.", x, y, insideCircleOutsideRectangle);



        }
    }

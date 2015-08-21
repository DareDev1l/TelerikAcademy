namespace Methods
{
    using System;

    public class TestUtils
    {
        public static void CalcUtilsTests()
        {
            Console.WriteLine(CalcUtils.CalcTriangleArea(3, 4, 5));
            Console.WriteLine(CalcUtils.FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine();
        }

        public static void PrintUtilsTests()
        {
            Console.WriteLine(PrintUtils.NumberToDigit(5));

            PrintUtils.PrintAsNumber(1.3, PrintFormat.DoublePrecision);
            PrintUtils.PrintAsNumber(0.75, PrintFormat.Percentage);
            PrintUtils.PrintAsNumber(2.30, PrintFormat.Right);

            Console.WriteLine();
        }

        public static void LineTests()
        {
            Line line = new Line(3, -1, 3, 2.5);

            Console.WriteLine(Line.CalcDistance(line));
            Console.WriteLine("Horizontal? " + Line.IsHorizontal(line));
            Console.WriteLine("Vertical? " + Line.IsVertical(line));

            Console.WriteLine();
        }

        public static void StudentsTests()
        {
            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1995, 12, 25));
            Student stella = new Student("Stella", "Markova", "Vidin", new DateTime(1992, 01, 17));

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));

            Console.WriteLine();
        }
    }
}

namespace Methods
{
    using System;

    public class Line
    {
        public Line(double x1, double y1, double x2, double y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            
            this.X2 = x2;
            this.Y2 = y2;
        }

        public double X1 { get; set; }

        public double X2 { get; set; }

        public double Y1 { get; set; }

        public double Y2 { get; set; }

        public static double CalcDistance(Line firstLine)
        {
            double firstSide = firstLine.X2 - firstLine.X1;
            double secondSide = firstLine.Y2 - firstLine.Y1;
            double distance = Math.Sqrt((firstSide * firstSide) + (secondSide * secondSide));

            return distance;
        }

        public static bool IsHorizontal(Line line)
        {
            return line.Y1 == line.Y2;
        }

        public static bool IsVertical(Line line)
        {
            return line.X1 == line.X2;
        }
    }
}

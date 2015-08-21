namespace Shapes
{
    public abstract class Shape
    {
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public abstract double CalculateSurface(double height, double width);
    }
}

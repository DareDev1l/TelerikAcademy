namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width) : base(height, width)
        {

        }

        public override double CalculateSurface(double height, double width)
        {
            return height * width / 2;
        }
    }
}

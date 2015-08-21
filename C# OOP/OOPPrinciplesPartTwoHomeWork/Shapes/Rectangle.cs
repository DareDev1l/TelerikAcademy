namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width)
        {

        }

        public override double CalculateSurface(double height, double width)
        {
            return height * width;
        }
    }
}

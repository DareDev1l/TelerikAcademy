namespace Shapes
{
    class Square : Shape
    {
        public Square(double side)
            : base(side, side)
        {

        }

        public override double CalculateSurface(double height , double width)
        {
            return height * width;
        }
    }
}

namespace Shapes
{
    using System;
    using System.Collections.Generic;
    public class ShapesTest
    {
        static void Main()
        {
            var shapes = new List<Shape>();

            shapes.Add(new Triangle(5, 2));
            shapes.Add(new Square(4));
            shapes.Add(new Rectangle(9, 8));

            foreach (var shape in shapes)
            {
                Console.WriteLine("The area of the {0} is {1:F1}", shape.GetType().Name, shape.CalculateSurface(shape.Height, shape.Width));
            }
        }
    }
}

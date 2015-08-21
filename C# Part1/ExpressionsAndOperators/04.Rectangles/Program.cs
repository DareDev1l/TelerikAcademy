using System;

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);

        Console.WriteLine("Area of rectangle is : {0}.  Perimeter is {1}", area , perimeter);
    }
}

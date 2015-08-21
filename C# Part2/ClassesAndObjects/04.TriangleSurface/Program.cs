using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Find triangular surface by:");
        Console.WriteLine("1.Side and altitude to it.");
        Console.WriteLine("2.Three sides.");
        Console.WriteLine("3.Two sides and angel between.");
        string input = Console.ReadLine();

        if(input == "1")
        {
            double side;
            double altitude;
            Console.Write("Enter side: ");
            side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude: ");
            altitude = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleSurface.AreaBySideAndAltitude(side, altitude));
        }
        else if(input == "2")
        {
            double side1;
            double side2;
            double side3;
            Console.Write("Enter side1: ");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter side2: ");
            side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter side3: ");
            side3 = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleSurface.AreaByThreeSides(side1,side2,side3));
        }
        else if(input == "3")
        {
            double side1;
            double side2;
            double angle;
            Console.Write("Enter side1: ");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter side2: ");
            side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter angle: ");
            angle = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleSurface.AreaBySidesAndAngel(side1,side2,angle));
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}


//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
public class TriangleSurface
{
    public static double AreaBySideAndAltitude(double side, double altitude)
    {
        return side * altitude / 2;
    }

    public static double AreaByThreeSides(double side1, double side2, double side3)
    {
        double p = (side1 + side2 + side3)/2.0;
        double expression = p * (p - side1) * (p - side2) * (p - side3);
        double area = Math.Sqrt(expression);

        return area;
    }

    public static double AreaBySidesAndAngel(double side1, double side2, double angle)
    {
        double area = (side1 * side2 * Math.Sin(Math.PI * angle / 180.0)) / 2;  

        return area;
    }
}
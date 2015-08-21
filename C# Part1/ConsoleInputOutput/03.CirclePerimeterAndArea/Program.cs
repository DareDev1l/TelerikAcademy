using System;

// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits
// after the decimal point.

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
      
        Console.WriteLine("Perimeter = {1:F2} \nArea = {0:F2}", area,perimeter);
    }
}

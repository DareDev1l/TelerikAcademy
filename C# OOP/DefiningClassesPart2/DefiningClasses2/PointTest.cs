namespace DefiningClasses2
{
    using System;
    using System.IO;
    public class Test
    {
        public static void Main()
        {
            // Create instances of 2 points
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(1, 3, 2);

            // Testing ToString() override
            Console.WriteLine("{0}  -->  ToString() test" , Point3D.PointO.ToString());
            Console.WriteLine("{0}  -->  ToString() test", point1.ToString());
            AddSeparator();

            // Calculate Distance Test
            Console.WriteLine("{0:F2}  -->  Calculate Distance test",Point3D.CalculateDistance(point1, point2));
            AddSeparator();

            // Load points test
            Console.WriteLine("PathStorage Load Method Test");
            Console.WriteLine();
            StreamReader reader = new StreamReader("../../PointsLoad.txt");

            var points = PathStorage.Load(reader);

            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine(points[i].ToString());
            }

            AddSeparator();
            
            // Save points test
            Console.WriteLine("PathStorage Save Method Test");
            Console.WriteLine();
            var writer = new StreamWriter("../../PointsSave.txt");
            PathStorage.Save(writer, points);
            Console.WriteLine("Save done!");
            AddSeparator();

        }

        public static void AddSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
        }
    }
}

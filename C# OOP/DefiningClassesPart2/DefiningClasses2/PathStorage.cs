namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public static class PathStorage
    {
        public static List<Point3D> Load(StreamReader reader)
        {
            List<Point3D> list = new List<Point3D>();

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    var coordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var point = new Point3D(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2]));

                    list.Add(point);

                    line = reader.ReadLine();
                }
            }

            return list;
        }

        public static void Save(StreamWriter writer, List<Point3D> points)
        {
            using (writer)
            {
                for (int index = 0; index < points.Count; index++)
			    {
                    writer.WriteLine("{0} {1} {2}", points[index].X, points[index].Y, points[index].Z);
			    }
            }
        }
    }
}

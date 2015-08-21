namespace DefiningClasses2
{
    public struct Point3D
    {
        private static readonly Point3D StartPoint = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D PointO
        {
            get { return StartPoint; }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static double CalculateDistance(Point3D p1 , Point3D p2)
        {
            return System.Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y) + (p2.Z - p1.Z) * (p2.Z - p1.Z));
        }

        public override string ToString()
        {
            return string.Format("({0} , {1} , {2})", this.X, this.Y, this.Z);
        }
    }
}

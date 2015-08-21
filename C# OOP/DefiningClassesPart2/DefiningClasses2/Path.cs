namespace DefiningClasses2
{
    public class Path
    {
        private System.Collections.Generic.List<Point3D> sequence = new System.Collections.Generic.List<Point3D>();

        public void Add(Point3D point)
        {
            sequence.Add(point);
        }

        public void Remove(Point3D point)
        {
            sequence.Remove(point);
        }
    }
}

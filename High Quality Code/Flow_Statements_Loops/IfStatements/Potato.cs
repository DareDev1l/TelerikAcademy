namespace IfStatements
{
    public class Potato
    {
        public Potato(double weight)
        {
            this.Weight = weight;
            this.HasBeenPeeled = false;
            this.IsRotten = false;
        }

        public double Weight { get; set; }

        public bool HasBeenPeeled { get; set; }

        public bool IsRotten { get; set; }
    }
}

namespace IfStatements
{
    public class IfStatements
    {
        public static void Main(string[] args)
        {
            Potato potato = new Potato(5);

            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }

        private static void Cook(Potato potato)
        {
            // Cook the potato
        }

        // This is the second snippet from Task 2
        private static void IfStatement()
        {
            const int MIN_X = 1;
            const int MAX_X = 10;
            const int MIN_Y = 0;
            const int MAX_Y = 9;

            int x = 3;
            int y = 4;

            bool isValidX = (MIN_X < x) && (x < MAX_X);
            bool isValidY = (MIN_Y < y) && (y < MAX_Y);
            bool shouldVisitCell = true;

            if (isValidX && isValidY && shouldVisitCell)
            {
               VisitCell();
            }
        }

        private static void VisitCell()
        {
            // Visit cell
        }
    }
}

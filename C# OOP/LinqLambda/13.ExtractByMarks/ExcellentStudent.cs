namespace _13.ExtractByMarks
{
    using System.Collections.Generic;
    public class ExcellentStudent
    {
        public string FirstName { get; set; }

        public List<int> Marks { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            string marks = string.Empty;

            foreach (var mark in this.Marks)
            {
                marks += mark + " ";
            }

            result = string.Format("{0} {1}", this.FirstName, marks);

            return result;

        }
    }
}

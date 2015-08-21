namespace _18.GroupStudents
{
    using System.Collections.Generic;
    using System.Linq;
    public class Group
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", 15202, "08991247513", "venci@abv.bg", new List<int>() { 2, 3, 2, 2 }, 2));
            students.Add(new Student("Teodor", "Hanev", 15203, "08878647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4 }, 3));
            students.Add(new Student("Atanas", "Draganov", 15204, "08791247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            var groupedStudents =
                from student in students
                group student by student.GroupNumber into grouped
                select new { Group = grouped.Key , Students = grouped.ToList()};

            foreach (var groupedStudent in groupedStudents)
            {
                System.Console.WriteLine("Group {0}: \n {1}", groupedStudent.Group, string.Join("\r\n\r\n", groupedStudent.Students));
                System.Console.WriteLine();
            }
        }
    }
}

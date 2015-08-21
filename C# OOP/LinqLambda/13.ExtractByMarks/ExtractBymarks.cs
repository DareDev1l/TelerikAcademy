//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties –
//FullName and Marks.
//Use LINQ.

namespace _13.ExtractByMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractBymarks
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", 15202, "08991247513", "venci@abv.bg", new List<int>() { 2, 3, 2, 2 }, 2));
            students.Add(new Student("Teodor", "Hanev", 15203, "08878647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4 }, 3));
            students.Add(new Student("Atanas", "Draganov", 15204, "08791247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            var studentsWithExcellentce =
                from student in students
                where student.Marks.Contains(6)
                select new ExcellentStudent()
                            {
                                FirstName = student.FirstName,
                                Marks = student.Marks
                            };

            foreach (var  student in studentsWithExcellentce)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

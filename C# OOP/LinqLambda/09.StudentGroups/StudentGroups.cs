//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StudentGroups
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", 15202, "08991247513", "venci@venci.com", new List<int>() { 2,3,2,2}, 2 ));
            students.Add(new Student("Teodor", "Hanev", 15203, "08998647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4}, 3));
            students.Add(new Student("Atanas", "Draganov", 15204, "08991247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            var grouped =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in grouped)
            {
                Console.WriteLine(student.ToString());
            }
        }

    }
}

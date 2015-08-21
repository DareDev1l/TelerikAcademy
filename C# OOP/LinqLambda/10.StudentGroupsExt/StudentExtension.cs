namespace _10.StudentGroupsExt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class StudentExtension
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", 15202, "08991247513", "venci@venci.com", new List<int>() { 2, 3, 2, 2 }, 2));
            students.Add(new Student("Teodor", "Hanev", 15203, "08998647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4 }, 3));
            students.Add(new Student("Atanas", "Draganov", 15204, "08991247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            var groupedStudents = students.Where(x => x.GroupNumber == 2).ToList();

            foreach (var student in groupedStudents)
            {
                Console.WriteLine(student.ToString());
            }


        }
    }
}

//Extract all students with phones in Sofia.
//Use LINQ.

namespace _12.ExtractByPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ExtractByPhone
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", 15202, "08991247513", "venci@abv.bg", new List<int>() { 2, 3, 2, 2 }, 2));
            students.Add(new Student("Teodor", "Hanev", 15203, "08878647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4 }, 3));
            students.Add(new Student("Atanas", "Draganov", 15204, "08791247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            // I will just extract those numbers which 3rd digit is 7 , because I am not from Sofia and I am not sure
            // about Sofia's telephone numbers

            var studentsWithSofiaNumbers =
                from student in students
                where student.TelephoneNumber[2] == '7'
                select student;

            foreach (var student in studentsWithSofiaNumbers)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

namespace _15.ExtractMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractMarks
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", "15206", "08991247513", "venci@abv.bg", new List<int>() { 2, 3, 2, 2 }, 2));
            students.Add(new Student("Teodor", "Hanev", "15204", "08878647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4 }, 3));
            students.Add(new Student("Atanas", "Draganov", "15206", "08791247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            var studentsMarks =
                from student in students
                where student.FN.EndsWith("06")//student.FN[student.FN.Length - 1] == 6 && student.FN[student.FN.Length - 2] == 0
                select student.Marks;

            Console.WriteLine("Marks of students from 2006:");

            foreach(var marks in studentsMarks)
            {
                foreach (var mark in marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
        }
    }
}

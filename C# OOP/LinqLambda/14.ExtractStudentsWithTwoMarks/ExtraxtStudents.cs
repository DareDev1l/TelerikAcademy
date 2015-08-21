//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

namespace _14.ExtractStudentsWithTwoMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ExtractStudents
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Venci", "Galabanov", 15202, "08991247513", "venci@abv.bg", new List<int>() { 2, 3, 2, 2 }, 2));
            students.Add(new Student("Teodor", "Hanev", 15203, "08878647513", "tedo@yahoo.com", new List<int>() { 2, 5, 2, 4 }, 3));
            students.Add(new Student("Atanas", "Draganov", 15204, "08791247164", "stoyko@gmail.com", new List<int>() { 5, 5, 6, 4 }, 2));

            var studentsWithPoorMarks =
                students.Where(x =>
                    {
                        int countOfTwo = 0;
                        foreach (var mark in x.Marks)
                        {
                            if (mark == 2)
                            {
                                countOfTwo++;
                            }
                        }

                        if (countOfTwo == 2)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    });

            foreach (var student in studentsWithPoorMarks)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

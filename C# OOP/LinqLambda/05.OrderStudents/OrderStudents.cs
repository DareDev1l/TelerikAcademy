//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
//name and last name in descending order.
//Rewrite the same with LINQ.

namespace _05.OrderStudents
{
    using System;
    using System.Linq;

    public class OrderStudents
    {
        static void Main()
        {
            var students = new[]
            {
                new {FirstName = "Gosho" , LastName = "Peshov"},
                new {FirstName = "Venci" , LastName = "Goshov"},
                new {FirstName = "Ivan" , LastName = "Kiriyakov"},
                new {FirstName = "Boyko" , LastName = "Borisov"},
                new {FirstName = "Vasil" , LastName = "Georgiev"},
                new {FirstName = "Dragan" , LastName = "Stoqnov"},
                new {FirstName = "Desislava" , LastName = "Nedqlkova"},
                new {FirstName = "Pesho" , LastName = "Goshov"},
                new {FirstName = "Pesho" , LastName = "Negoshov"},
                new {FirstName = "Abraham" , LastName = "Lincoln"},
                new {FirstName = "Abraham" , LastName = "York"}
            };

            var sortedStudents = students.OrderByDescending(x => x.FirstName)
                                         .ThenByDescending(x => x.LastName)
                                         .ToList();

            var sortedStudentsLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("Lambda:");
            Console.WriteLine(new string('-', 50));
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nLinq:");
            Console.WriteLine(new string('-', 50));
            foreach (var student in sortedStudentsLinq)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

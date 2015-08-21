//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace _04.FirstBeforeLast
{
    using System;
    using System.Linq;

    public class AgeRange
    {
        static void Main()
        {
            var students = new[]
            {
                new {FirstName = "Gosho" , LastName = "Peshov", Age = 20},
                new {FirstName = "Venci" , LastName = "Goshov", Age = 29},
                new {FirstName = "Ivan" , LastName = "Kiriyakov", Age = 30},
                new {FirstName = "Boyko" , LastName = "Borisov", Age = 18},
                new {FirstName = "Vasil" , LastName = "Georgiev", Age = 24},
                new {FirstName = "Dragan" , LastName = "Stoqnov", Age = 23},
                new {FirstName = "Desislava" , LastName = "Nedqlkova", Age = 47},
                new {FirstName = "Pesho" , LastName = "Goshov", Age = 83},
                new {FirstName = "Abraham" , LastName = "Lincoln", Age = 15}
            };

            var sortedStudents =
                from student in students
                where student.Age <= 24 && student.Age >= 18
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}

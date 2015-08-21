//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

namespace _03.FirstBeforeLast
{
    using System;
    using System.Linq;
    
    public class FirstBeforeLast
    {
        static void Main()
        {
            var students = new[]
            {
                new {FirstName = "Gosho" , LastName = "Peshov"},
                new {FirstName = "Venci" , LastName = "Goshov"},
                new {FirstName = "Ivan" , LastName = "Kiriyakov"},
                new {FirstName = "Radoslav" , LastName = "Radkov"},
                new {FirstName = "Georgi" , LastName = "Purvanov"},
                new {FirstName = "Boyko" , LastName = "Borisov"},
                new {FirstName = "Vasil" , LastName = "Georgiev"},
                new {FirstName = "Dragan" , LastName = "Stoqnov"},
                new {FirstName = "Desislava" , LastName = "Nedqlkova"},
                new {FirstName = "Pesho" , LastName = "Goshov"},
                new {FirstName = "Abraham" , LastName = "Lincoln"}
            };
            //x => x.FirstName.CompareTo(x.LastName)
            var sortedStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

namespace _15.ExtractMarks
{
    using System.Collections.Generic;
    using System;
    public class Student
    {
        public Student(string firstName, string lastName, string FN, string telephoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = FN;
            this.TelephoneNumber = telephoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FN { get; set; }

        public string TelephoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public override string ToString()
        {
            string result;
            string marks = string.Empty;

            foreach (var mark in this.Marks)
            {
                marks += mark + " ";
            }

            result = String.Format("{0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}", this.FirstName, this.LastName, this.FN, this.TelephoneNumber, this.Email, marks, this.GroupNumber);

            return result;
        }
    }
}

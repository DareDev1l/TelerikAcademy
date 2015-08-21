namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string birthPlace;

        public Student(string firstName, string lastName, string birthPlace, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthPlace = birthPlace;
            this.BirthDate = birthDate;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Firstname should be a non-empty string");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Lastname should be a non-empty string");
                }

                this.lastName = value;
            }
        }

        public string BirthPlace
        {
            get
            {
                return this.birthPlace;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Birthplace should be a non-empty string");
                }

                this.birthPlace = value;
            }
        }

        public DateTime BirthDate { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.BirthDate;
            DateTime secondDate = other.BirthDate;

            return firstDate > secondDate;
        }
    }
}

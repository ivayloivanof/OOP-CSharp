using System;

namespace P01_Human_Student_and_Worker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faculty number must be between 5 and 10 digits.");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} is a student with faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
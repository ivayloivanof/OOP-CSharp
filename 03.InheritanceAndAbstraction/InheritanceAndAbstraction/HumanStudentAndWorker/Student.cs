using System;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private int facultyNumber;
        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                int a;
                bool num = int.TryParse(value.ToString(), out a);
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Number is negative!");
                if (!num)
                    throw new FormatException();
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, int facultyNumber)
        {
            DateTime date = DateTime.Now;
            facultyNumber = int.Parse(facultyNumber.ToString() + date.DayOfYear + date.Year);
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }
    }
}

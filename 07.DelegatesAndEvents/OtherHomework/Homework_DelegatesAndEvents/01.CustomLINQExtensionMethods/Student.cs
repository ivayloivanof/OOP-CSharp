using System;

namespace AdditionalUnits
{
    public class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Your name can not be null or empty");
                }

                this.name = value;
            }
        }

        public int Grade
        {
            get { return this.grade; }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("value", "The grade of your student must be between 2 and 6");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Student name: {0}, Student grade: {1}", this.Name, this.Grade);
        }
    }
}

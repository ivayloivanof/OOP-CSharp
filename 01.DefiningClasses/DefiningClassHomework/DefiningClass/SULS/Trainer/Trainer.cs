using System;

namespace SULS.Trainer
{
    class Trainer
    {
        private string courseName;

        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "This course name is null or empty and do not create!");
                }
                this.courseName = value;
            }
        }

        private void CreateCourse(string courseName)
        {
            this.CourseName = courseName;
        }

        public override string ToString()
        {
            return this.courseName.ToString();
        }
    }
}

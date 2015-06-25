using System;

namespace StudentClass
{
    public delegate void OnPropertyChangeEventHandler(Student student, PropertyChangedEventArgs args);

    public class Student
    {
        public event OnPropertyChangeEventHandler PropertyChanged;
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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

                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new PropertyChangedEventArgs("Name", this.name, value));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("value", "Your age must be in interval from 0 to 120");
                }

                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age", this.age, value));
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Student name: {0}, Student age: {1}", this.Name, this.Age);
        }
    }
}
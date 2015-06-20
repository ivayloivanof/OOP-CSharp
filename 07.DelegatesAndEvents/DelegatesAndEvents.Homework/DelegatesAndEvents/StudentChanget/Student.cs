using System.ComponentModel;

namespace StudentChanged
{
    public delegate void OnPropertyChangeEventHandler(Student student, ChangedEventArgs args);

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
            get
            {
                return this.name;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new ChangedEventArgs("Name", this.name, value));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new ChangedEventArgs("Age", this.age, value));
                }

                this.age = value;
            }
        }
    }
}

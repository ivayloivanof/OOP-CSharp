using System;

namespace _01.Persons
{
    class Persons
    {
        private string name;
        private int age;
        private string email;

        public Persons(string name, int age) : this(name, age, null)
        {
        }

        public Persons(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be empty!");
                }
                this.name = value;
            } 
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid age!");
                }
                this.age = value;
            } }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == string.Empty || !value.Contains("@"))
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid email address!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, Age = {1}, email = {2}", this.Name, this.Age, this.Email ?? "No email");
        }
    }
}

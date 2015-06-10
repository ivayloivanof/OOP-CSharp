using System;
using CompanyHierarchy.Interfaces;
namespace CompanyHierarchy.Class
{
    class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentOutOfRangeException("ID must be 0 betwen 1000!");
                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("First name cannot be empty!");
                this.firstName = value.Trim();
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Last name cannot be empty!");
                this.lastName = value.Trim();
            }
        }

        public Person(string firstName, string lastName, int id = 1)
        {
            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
            this.Id = id;
        }

        public override string ToString()
        {
            Console.WriteLine("First name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Id: {0}", this.Id);
            return string.Empty;
        }
    }
}

using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Class.Employee
{
    class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;    //{ Production, Accounting, Sales, Marketing };

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                this.salary = value;
            }
        }
        public string Department
        {
            get { return this.department; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Department cannot be empty or null!");
                }
                if (value == "Production" || value == "Accounting" || value == "Sales" || value == "Marketing")
                {
                    this.department = value.Trim();
                }
                else
                {
                    throw new ArgumentException("Not valid department!");
                }
            }
        }

        public Employee(string firstName, string lastName, decimal salary, int id = 1, string department = "Production")
            : base(firstName, lastName, id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Salary = salary;
            this.Department = department;
        }

        public override string ToString()
        {
            Console.WriteLine("First name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine("Department: {0}", this.Department);
            return string.Empty;
        }
    }
}

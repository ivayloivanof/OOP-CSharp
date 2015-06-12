using P03_Company_Hierarchy.Interfaces;
using System;

namespace P03_Company_Hierarchy.People
{
    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(int id, string firstName, string lastName, decimal salary, string department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Department
        {
            get{return this.department;}
            set
            {
                if (value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new ArgumentException("Department should be one of the following: Production, Accounting, Sales or Marketing.");
                }

                this.department = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Employee with ID: {0} - {1} {2}, Department: {3}, Salary: {4}", 
                                                this.Id, this.FirstName, this.LastName, this.Department, this.Salary);
        }
    }
}
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
    }
}

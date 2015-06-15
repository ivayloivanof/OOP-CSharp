using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public abstract class Employee:Person,IEmployee
    {
        private double salary;
        protected Employee(string id, string firstname, string lastname, double salary, Department department):base(id,firstname,lastname)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The value of salary is out of range!");
                }
                this.salary = value;
            }
        }
        public Department Department { get; set; }

        public override string ToString()
        {
            return string.Format("Id {0}, Firsname {1} Lastname {2} Salary: {3} Department: {4}",this.Id,this.Firstname,this.Lastname,this.Salary,this.Department);
        }
    }
}

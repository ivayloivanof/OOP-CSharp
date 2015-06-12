using P03_Company_Hierarchy.Interfaces;
using System.Text;

namespace P03_Company_Hierarchy.People
{
    public class Manager : Employee, IManager
    {
        private Employee[] employees;

        public Manager(int id, string firstName, string lastName, decimal salary, string department, Employee[] employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }
        public Employee[] Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Manager with ID: {0} - {1} {2}, who manages the following employees: ", this.Id, this.FirstName, this.LastName));
            int index = 1;
            foreach (Employee emp in this.Employees)
            {
                info.AppendLine(string.Format("Employee {0}: {1} {2}", index, emp.FirstName, emp.LastName));
                index++;
            }

            return info.ToString();
        }
    }
}
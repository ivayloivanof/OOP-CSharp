using System.Collections.Generic;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Class.Employee
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public List<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                
            }
        }

        public Manager(string firstName, string lastName, decimal salary, int id = 1, string department = "Production")
            : base(firstName, lastName, salary, id)
        {
            Employee employee = new Employee(firstName, lastName, salary, id, department);
        }
    }
}

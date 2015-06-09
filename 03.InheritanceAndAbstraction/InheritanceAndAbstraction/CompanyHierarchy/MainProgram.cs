using CompanyHierarchy.Class;
using CompanyHierarchy.Class.Employee;
using CompanyHierarchy.Class.Employee.RegularEmployer;

namespace CompanyHierarchy
{
    using Interfaces;
    class MainProgram
    {
        static void Main()
        {
            IPerson person = new Person("Ivan", "Ivanov");
            IPerson employee = new Employee();
            IPerson manager = new Manager();

            IPerson salesEmployee = new SalesEmployee();
            IPerson developer = new Developer();
        }
    }
}

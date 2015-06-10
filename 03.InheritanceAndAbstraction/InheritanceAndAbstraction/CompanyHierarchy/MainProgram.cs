using System;
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
            Console.WriteLine(person);
            Console.WriteLine();
            IPerson employee = new Employee("Asen", "Dimitrov", 156.65m, 2);
            Console.WriteLine(employee);
            Console.WriteLine();
            Developer developer = new Developer("Blagoi", "Spasov", 115.65m, 3, "Accounting");
            developer.CreateProject("Напиши нещо", DateTime.Now, "Каквото си поискаш");
            developer.CreateProject("Напиши нещо1", DateTime.Now, "Каквото си поискаш1");
            developer.CreateProject("Напиши нещо2", DateTime.Now, "Каквото си поискаш2");
            developer.CloseProject("Напиши нещо1");
            Console.WriteLine(developer);
            Console.WriteLine();
            SalesEmployee salesEmployee = new SalesEmployee("Anastas", "Dimov", 135.25m, 4, "Sales");
            salesEmployee.CreateSales("Product 1", DateTime.Now, 125m);
            salesEmployee.CreateSales("Product 2", DateTime.Now, 155m);
            salesEmployee.CreateSales("Product 3", DateTime.Now, 195m);
            Console.WriteLine(salesEmployee);
            Console.WriteLine();

            //IPerson developer = new Developer();
        }
    }
}

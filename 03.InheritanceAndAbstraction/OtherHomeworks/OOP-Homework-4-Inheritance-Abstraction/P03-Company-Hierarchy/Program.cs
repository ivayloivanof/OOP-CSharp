using P03_Company_Hierarchy.People;
using P03_Company_Hierarchy.Projects;
using System;

namespace P03_Company_Hierarchy
{
    class Program
    {
        static void Main()
        {
            Employee[] employees = 
            {
                new Manager(110000, "Peter", "Petrov", 1800, "Marketing",
                    new Employee[] {
                                new Employee(110011, "Anka", "Petrova", 1000, "Marketing"),
                                new Employee(110012, "Penka", "Ivanova", 990, "Marketing"),
                                new Employee(110013, "Ivanka", "Pehlivanova", 950, "Marketing")
                    }),
                new SalesEmployee(550023, "Georgi", "Georgiev", 1200, "Sales", 
                    new Sale[] {
                                new Sale("Computer", new DateTime(2015, 6, 7), 1800),
                                new Sale("Printer", new DateTime(2015, 6, 8), 1540),
                                new Sale("Scanner", new DateTime(2015, 6, 9), 1234)
                    }),
                new Developer(220043, "Ivan", "Ivanov", 2100, "Accounting", 
                    new Project[] {
                                new Project("OnlineShop", new DateTime(2015, 7, 1), "online shop for computers", "open"),
                                new Project("Accounting Audit", new DateTime(2015, 7, 1), "middle year accounting audit", "open")
                    })
            };

            foreach (var person in employees)
            {
                Console.WriteLine(person);
            }
        }
    }
}
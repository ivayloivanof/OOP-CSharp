using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Class.Employee.RegularEmployer
{
    class SalesEmployee : Employee
    {
        private List<string[]> sales = new List<string[]>();
        private string productName;
        private DateTime date;
        private decimal price;

        public SalesEmployee(string firstName, string lastName, decimal salary, int id = 1, string department = "Sales")
            : base(firstName, lastName, salary, id, department)
        {
            department = "Sales";
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Id = id;
            this.Department = department;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Product name cannot be empty!");
                this.productName = value.Trim();
            }
        }
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                DateTime date;
                DateTime.TryParse(value.ToString(), out date);
                this.date = date;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                decimal.TryParse(value.ToString(), out value);
                this.price = value;
            }
        }

        public void CreateSales(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
            string[] name = {this.ProductName, this.Date.ToString(), this.Price.ToString()};
            sales.Add(name);
        }

        public override string ToString()
        {
            Console.WriteLine("First name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine("Department: {0}", this.Department);
            Console.WriteLine(new string('-', 25));
            for (int i = 0; i < this.sales.Count; i++)
            {
                Console.WriteLine("Product name: {0}", this.sales[i][0]);
                Console.WriteLine("Date: {0}", this.sales[i][1]);
                Console.WriteLine("Price: {0}", this.sales[i][2]);
                Console.WriteLine(new string('-', 25));
            }
            return string.Empty;
        }
    }
}

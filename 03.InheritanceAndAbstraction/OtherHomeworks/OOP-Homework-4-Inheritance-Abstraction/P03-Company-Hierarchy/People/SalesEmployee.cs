using P03_Company_Hierarchy.Interfaces;
using P03_Company_Hierarchy.Projects;
using System.Text;

namespace P03_Company_Hierarchy.People
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private Sale[] sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, string department, Sale[] sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }
        public Sale[] Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Sales Employee with ID: {0} - {1} {2}, who sells the following products: ", this.Id, this.FirstName, this.LastName));
            int index = 1;
            foreach (Sale sale in this.Sales)
            {
                info.AppendLine(string.Format("{0}. Product Name: {1}, Price: {2} BGN", index, sale.ProductName, sale.Price));
                index++;
            }

            return info.ToString();
        }
    }
}
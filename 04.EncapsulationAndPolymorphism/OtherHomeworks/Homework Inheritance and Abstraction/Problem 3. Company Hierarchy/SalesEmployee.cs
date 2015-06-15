using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public class SalesEmployee:RegularEmployee,ISalesEmployee
    {
        private List<Sale> saleslist; 
        public SalesEmployee(string id, string firstname, string lastname, double salary, Department department) : base(id, firstname, lastname, salary, department)
        {
        }

        public List<Sale> SalesList
        {
            get { return this.saleslist; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("Sales cannot be null.");
                }
                this.saleslist = value;
            }
        }

        public override string ToString()
        {
            string sales = string.Join("\n", this.SalesList);
            return string.Format("Id {0}, Salary: {1}, Department: {2}, Sales: {3}",this.Id,this.Salary,this.Department,sales);
        }
    }
}

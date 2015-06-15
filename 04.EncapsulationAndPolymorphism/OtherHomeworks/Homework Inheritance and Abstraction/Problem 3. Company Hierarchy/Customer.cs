using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public class Customer:Person,ICustomer
    {
        public Customer(string id, string firstname, string lastname) : base(id, firstname, lastname)
        {
        }

        public double NetPurchaseAmount { get; set; }

        public override string ToString()
        {
            return string.Format("");
        }
    }
}

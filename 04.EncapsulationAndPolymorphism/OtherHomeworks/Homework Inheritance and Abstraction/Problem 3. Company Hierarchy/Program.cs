using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    class Program
    {
        static void Main()
        {
            Sale cocacola=new Sale("Coca Cola",new DateTime(2015,3,4),2.25);
            Sale fantalimon=new Sale("Fanta Limon",new DateTime(2015,4,27),2.30);
            Sale fantaportokal=new Sale("Fanta Portokal",new DateTime(2015,2,16),2.40);

            List<Sale> sales=new List<Sale>();
            sales.Add(cocacola);
            sales.Add(fantalimon);
            sales.Add(fantaportokal);


        }
    }
}

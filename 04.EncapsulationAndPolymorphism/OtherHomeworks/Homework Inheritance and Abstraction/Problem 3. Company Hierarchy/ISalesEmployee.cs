using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
     public interface ISalesEmployee
    {
        List<Sale> SalesList { get; set; }
    }
}

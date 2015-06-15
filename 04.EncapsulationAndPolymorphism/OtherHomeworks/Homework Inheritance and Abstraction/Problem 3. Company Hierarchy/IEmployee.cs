using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public enum Department
    {
        Production,
        Accounting,
        Marketing,
    }
    public interface IEmployee
    {

        double Salary { get; set; }
        Department Department { get; set; }
    }
}

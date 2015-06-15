using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public class Developer:RegularEmployee,IDeveloper
    {
        public Developer(string id, string firstname, string lastname, double salary, Department department) : base(id, firstname, lastname, salary, department)
        {
        }

        public override string ToString()
        {
            return string.Format("");
        }
    }
}

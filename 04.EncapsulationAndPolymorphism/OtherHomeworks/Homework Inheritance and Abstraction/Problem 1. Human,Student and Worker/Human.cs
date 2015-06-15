using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Human_Student_and_Worker
{
    public abstract class Human
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Human(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
    }
}

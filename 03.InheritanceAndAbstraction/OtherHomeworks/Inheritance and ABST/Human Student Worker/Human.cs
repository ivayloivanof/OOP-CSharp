using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_Worker
{
    abstract class Human
    {
        private string firstN;
        private string lastN;

        public Human(string name,string lastN)
        {
            this.FirstName = name;
            this.LastName = lastN;
        }

        public string FirstName
        {
            get { return this.firstN; }
            set { this.firstN = value; }
        }

        public string LastName
        {
            get
            {
                return this.lastN;
            }
            set { this.lastN = value; }
        }
    }
}

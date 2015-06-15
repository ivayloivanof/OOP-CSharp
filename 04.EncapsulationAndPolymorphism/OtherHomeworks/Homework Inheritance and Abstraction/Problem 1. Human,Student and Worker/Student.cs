using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Human_Student_and_Worker
{
    public class Student:Human
    {
        private string facultynumber;
        public Student(string firstname, string lastname, string facultynumber) : base(firstname, lastname)
        {
            this.Facultynumber = facultynumber;
        }

        public string Facultynumber
        {
            get { return this.facultynumber; }
            set
            {
                if (!(value.Length>=5 && value.Length<=10))
                {
                    throw new ArgumentOutOfRangeException("Invalid faculty number!");
                }
                this.facultynumber = value;
            }
        }
    }
}

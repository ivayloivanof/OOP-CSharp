using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human_Student_Worker;

namespace Human_Student_and_Worker
{
    class Student : Human
    {
        private string facluty;


        public Student(string firstN, string lastN, string faculty)
            : base(firstN, lastN)
        {
            this.FacultyNumber = faculty;
        }

        public string FacultyNumber
        {
            get { return this.facluty; }
            set
            {
                this.facluty = value;
                if (this.facluty.Length > 10 || this.facluty.Length < 5)
                {
                    throw new Exception("Invalid faculty number!");
                }
                
                
            }
        }
    }
}

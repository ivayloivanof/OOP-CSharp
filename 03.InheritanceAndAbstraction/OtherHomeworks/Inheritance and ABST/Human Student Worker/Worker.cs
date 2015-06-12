using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_Worker
{
    class Worker: Human
    {
        private double weekSalary;
        private double workHours;
        public Worker(string name, string lastN,double weekSalary,double workHours) : base(name, lastN)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay= workHours;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHours; }
            set
            {
                this.workHours = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary/this.WorkHoursPerDay;
           ;
        }
    }
}

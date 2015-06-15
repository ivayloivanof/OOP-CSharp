using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Human_Student_and_Worker
{
   public class Worker:Human
    {
       private const int workdays=5;
       public Worker(string firstname, string lastname, double weekSalary, int workHoursPerDay) : base(firstname, lastname)
       {
           WeekSalary = weekSalary;
           WorkHoursPerDay = workHoursPerDay;
       }

       public double WeekSalary { get; set; }
       public int WorkHoursPerDay { get; set; }

       public double MoneyPerHour()
       {
           double moneyperhour = (this.WeekSalary/workdays)/this.WorkHoursPerDay;
           return moneyperhour;
       }
    }
}

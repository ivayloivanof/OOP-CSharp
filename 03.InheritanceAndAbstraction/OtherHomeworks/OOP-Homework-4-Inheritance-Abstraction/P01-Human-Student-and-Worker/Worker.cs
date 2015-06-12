using System;

namespace P01_Human_Student_and_Worker
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public double MoneyPerHour()
        {
            double hoursPerWeek = 5 * this.WorkHoursPerDay;
            double hourSalary = this.WeekSalary / hoursPerWeek;

            return hourSalary;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} is a worker, who earns {2} BGN per hour.", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
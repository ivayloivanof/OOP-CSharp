using System;

namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal payPerHour;
        private static readonly Random random = new Random();

        private decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        private int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException("Worker not work this day!");
                if (value > 16)
                    throw new ArgumentOutOfRangeException("Worker needs rest in order not to die!");
                this.workHoursPerDay = value;
            }
        }

        public decimal PayPerHour
        {
            get { return this.payPerHour; }
            set { this.payPerHour = value; }
        }

        public Worker(string firstName, string lastName, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = MoneyPerDay(WorkHoursPerDay);
        }

        private decimal MoneyPerDay(int hours)
        {
            this.PayPerHour = RandomPeyPerHours(10, 75);
            return PayPerHour*hours;
        }
        
        private static decimal RandomPeyPerHours(decimal minValue, decimal maxValue)
        {
            var next = random.NextDouble();
            return minValue + ( (decimal) next * (maxValue - minValue)) - (decimal) next;
        }
    }
}

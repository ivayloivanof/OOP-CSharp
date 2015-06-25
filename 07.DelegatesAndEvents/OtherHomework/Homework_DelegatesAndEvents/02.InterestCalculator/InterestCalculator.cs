using System;

namespace Calculator
{
    public class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        private Func<decimal, decimal, int, decimal> calculateInterest;

        public InterestCalculator(decimal money, decimal interest, int years,
            Func<decimal, decimal, int, decimal> calculateInterest)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.CalculateInterest = calculateInterest(money, interest, years);
        }

        public decimal Money
        {
            get { return this.money; }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("value", "The money in your bank account can not be negative");
                }

                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("value", "The value of your interest can not be negative");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get { return this.years; }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("value", "Your years must be between 1 and 100");
                }

                this.years = value;
            }
        }

        public decimal CalculateInterest { get; set; }

        public override string ToString()
        {
            return String.Format("Money: {0}, Interest: {1}%, Years: {2}, Result: {3:F4}", this.Money, this.Interest,
                this.Years, this.CalculateInterest);
        }
    }
}
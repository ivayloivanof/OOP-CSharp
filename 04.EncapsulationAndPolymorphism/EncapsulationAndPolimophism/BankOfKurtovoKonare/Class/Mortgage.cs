using System;

namespace BankOfKurtovoKonare.Class
{
    class Mortgage : Accounts
    {
        public Mortgage(string customer, decimal balance) : base (customer)
        {
            this.Balance = balance;
            if (customer.Contains("company"))
            {
                this InterestRate = 
            }
            this.InterestRate 
        }

        public override decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value > 0)
                    throw new ArgumentOutOfRangeException("Cannot be created Mortgage Account with balance > 0. Balance must be negative!");
                this.balance = value;
            }
        }

        public override int InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
    }
}

using System;

namespace BankOfKurtovoKonare.Class
{
    using Interfaces;
    abstract class Accounts : IAccount
    {
        private decimal balance;
        private decimal interestRate;

        public Accounts(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException("balance", "The balance cannot be negative!");
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException("interest rate", "InterestRate cannot be negative number!");    
                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Account: {0}\nBalance = {1}\nInterest rate = {2}\n", this.GetType().Name, this.Balance, this.InterestRate);
        }
    }
}

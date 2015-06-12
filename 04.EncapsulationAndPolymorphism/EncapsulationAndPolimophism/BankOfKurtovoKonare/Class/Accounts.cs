using System;

namespace BankOfKurtovoKonare.Class
{
    abstract class Accounts
    {
        private string customer;
        protected decimal balance;
        protected int interestRate;

        public Accounts(string customer)
        {
            this.Customer = customer;
        }

        public string Customer
        {
            get { return this.customer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("This customer not valid!");
                this.customer = value.Trim();
            }
        }
        public abstract decimal Balance { get; set; }
        public abstract int  InterestRate { get; set; }


    }
}

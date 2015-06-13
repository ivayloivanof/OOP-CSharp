﻿namespace BankOfKurtovoKonare.Class
{
    using Interfaces;
    class Loan : Accounts
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 3 && this.Customer == Customer.individual)
                return 0;
            else if (months < 2 && this.Customer == Customer.company)
                return 0;
            return this.InterestRate = this.Balance * (1 + this.InterestRate * months);
        }
    }
}

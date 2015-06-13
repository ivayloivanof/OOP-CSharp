using System;

namespace BankOfKurtovoKonare.Class
{
    class Mortgage : Accounts
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 6 && this.Customer == Customer.individual)
                return 0;
            else if (months < 12 && this.Customer == Customer.company)
                return this.InterestRate = (this.Balance*(1 + this.InterestRate*months)) / 2;
            return this.InterestRate = this.Balance*(1 + this.InterestRate*months);
        }
    }
}

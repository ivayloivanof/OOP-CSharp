using System;
using BankOfKurtovoKonare.Class;

namespace BankOfKurtovoKonare
{
    class Program
    {
        static void Main()
        {
            try
            {
                Deposit deposit = new Deposit(Customer.company, 14500m, 3.4m);
                deposit.Withdraw(3255m);
                deposit.DepositMoney(1000m);
                deposit.CalculateInterest(6);
                Console.WriteLine("Deposit: {0}", deposit);

                Loan loanIndividual = new Loan(Customer.individual, 1000m, 23m);
                loanIndividual.DepositMoney(3560m);
                loanIndividual.CalculateInterest(5);
                Console.WriteLine("Loan individual: {0}", loanIndividual);

                Loan loanCompalny = new Loan(Customer.company, 140600m, 5m);
                loanCompalny.DepositMoney(43000m);
                loanCompalny.CalculateInterest(3);
                Console.WriteLine("Loan company: {0}", loanCompalny);

                Mortgage mortageIndividual = new Mortgage(Customer.individual, 580, 3.3m);
                mortageIndividual.DepositMoney(240m);
                mortageIndividual.CalculateInterest(7);
                Console.WriteLine("Mortgage individual: {0}", mortageIndividual);

                Mortgage mortageCompany = new Mortgage(Customer.company, 53400, 5m);
                mortageIndividual.DepositMoney(2500m);
                mortageIndividual.CalculateInterest(17);
                Console.WriteLine("Mortgage individual: {0}", mortageIndividual);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

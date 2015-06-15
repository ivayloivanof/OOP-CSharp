using BankOfKurtovoKonare.Models;

namespace BankOfKurtovoKonare.Interface
{
    interface IAccount
    {
        Customer Customer { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        void Deposit(decimal money);

        decimal Interest(int months);
    }
}

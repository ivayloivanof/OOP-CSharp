using BankOfKurtovoKonare.Class;

namespace BankOfKurtovoKonare.Interfaces
{
    interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        void DepositMoney(decimal money);
        decimal CalculateInterest(int months);
    }

}

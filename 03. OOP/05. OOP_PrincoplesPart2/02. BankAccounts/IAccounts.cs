namespace _02.BankAccounts
{
    public interface IAccounts
    {
        ICustomers Customer { get; set; }
        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        decimal CalculateInterestAmount(int numberOfMounths);

        decimal DepositMoney(decimal money);

        decimal DrawMoney(decimal money);
    }
}

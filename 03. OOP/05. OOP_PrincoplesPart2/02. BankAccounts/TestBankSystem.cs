namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    public class TestBankSystem
    {
        public static void Main()
        {
            Bank bank = new Bank();
            bank.AddAccount(new LoanAccounts(new Individuals("Pesho Ivanov"), 1000, 20));
            bank.AddAccount(new MortgageAccounts(new Companies("TeeeeeC LTD"), 100, 200));
            bank.AddAccount(new DepositAccouts(new Individuals("Gosho Petrov"), 1000, 2));
            foreach (var account in bank.Accounts)
            {
                Console.WriteLine("{0} for {1} with interest amount = {2} BGN", account.GetType().Name, account.Customer.Name, account.CalculateInterestAmount(12));
                account.DepositMoney(50);
                account.DrawMoney(100);
                Console.WriteLine(account.Balance);
            }
        }
    }
}

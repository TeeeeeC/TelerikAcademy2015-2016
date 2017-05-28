namespace _02.BankAccounts
{
    using System;

    public class LoanAccounts : IAccounts
    {
        public LoanAccounts(ICustomers customer, decimal balance, decimal interesRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interesRate;
        }

        public ICustomers Customer { get; set; }
        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public decimal DepositMoney(decimal money)
        {
            this.Balance += money;
            return this.Balance;
        }

        public decimal CalculateInterestAmount(int numberOfMounths)
        {
            if (numberOfMounths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months must be bigger than 0!");
            }

            if (this.Customer is Individuals)
            {
                if (numberOfMounths > 3)
                {
                    return numberOfMounths * this.InterestRate;
                }
                return 0;
            }
            else
            {
                if (numberOfMounths > 2)
                {
                    return numberOfMounths * this.InterestRate;
                }
                return 0;
            }
        }

        public decimal DrawMoney(decimal money)
        {
            Console.WriteLine("You cannot draw money!");
            return this.Balance;
        }
    }
}

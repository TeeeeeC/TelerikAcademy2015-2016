namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    public class Bank 
    {
        private ICollection<IAccounts> accounts = new List<IAccounts>();

        public ICollection<IAccounts> Accounts 
        { 
            get
            {
                return this.accounts;
            }
        }

        public void AddAccount(IAccounts account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(IAccounts account)
        {
            this.accounts.Remove(account);
        }
    }
}

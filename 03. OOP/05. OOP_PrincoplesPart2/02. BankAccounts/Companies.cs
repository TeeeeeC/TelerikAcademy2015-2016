namespace _02.BankAccounts
{
    using System;

    public class Companies : ICustomers
    {
        private string name;

        public Companies(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Enter company name with at least 3 symbols!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}

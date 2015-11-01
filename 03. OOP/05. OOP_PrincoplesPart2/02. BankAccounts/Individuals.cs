namespace _02.BankAccounts
{
    using System;

    public class Individuals : ICustomers
    {
        private string name;

        public Individuals(string name)
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
                if(value.Length < 10 || !value.Contains(" "))
                {
                    throw new ArgumentException("Enter valid first and last name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}

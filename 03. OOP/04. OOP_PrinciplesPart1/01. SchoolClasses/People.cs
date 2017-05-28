namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class People 
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(value.Length < 3 && value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Please enter name in range(3-20 lenght)");
                }
                this.name = value;
            }
        }
    }
}

namespace _03.AnimalHierarchy
{
    using System;

    public class Kittens : Cat
    {
        private string sex;

        public Kittens(string name, int age, string sex)
            : base(name, age) 
        {
            this.Gender = sex;
        }

        public string Gender
        {
            get
            {
                return this.sex;
            }
            private set
            {
                if (value != "female")
                {
                    throw new ArgumentOutOfRangeException("Kittens can be only female!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }
    }
}

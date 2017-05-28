namespace _03.AnimalHierarchy
{
    using System;

    public class TomCat : Cat
    {
         private string sex;

        public TomCat(string name, int age, string sex)
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
                if (value != "male")
                {
                    throw new ArgumentOutOfRangeException("Kittens can be only male!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }
    }
}

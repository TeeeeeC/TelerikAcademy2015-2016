namespace _03.AnimalHierarchy
{
    using System;

    public class Animal 
    {
        private string name;
        private int age;
        private string sex;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, string sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 3 && value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Enter valid name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 1 && value > 15)
                {
                    throw new ArgumentOutOfRangeException("Enter correct age!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Sex 
        { 
            get
            {
                return this.sex;
            }
            private set
            {
                if(value != "male" && value != "female")
                {
                    throw new ArgumentOutOfRangeException("Enter correct gender!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }
    }
}

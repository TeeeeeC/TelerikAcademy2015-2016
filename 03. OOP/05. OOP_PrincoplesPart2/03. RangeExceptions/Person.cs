namespace _03.RangeExceptions
{
    using System;

    public class Person
    {
        private int age;
        private DateTime birthday;

        public Person(string name, int age, DateTime birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
        }

        public string Name { get; set; }

        public int Age 
        { 
            get
            {
                return this.age;
            }
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new InvalidRangeException<int>("Invalid age!") { InvalidRangeDescription = "Invalid age [1-100]!" };
                }
                this.age = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                if (value < new DateTime(1980, 1, 1) || value > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<int>("Invalid birthday!") { InvalidRangeDescription = "Invalid birthday [1.1.1980-31.12.2013]!" };
                }
                this.birthday = value;
            }
        }
    }
}

namespace _02.PersonClass
{
    using System;

    public class PersonGenerator
    {
        public void Generate(int age)
        {
            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.FullName = "Pesho Ivanov";
                person.Gender = Gender.male;
            }
            else
            {
                person.FullName = "Pepa Ivanova";
                person.Gender = Gender.female;
            }

            Console.WriteLine(person.FullName + " " + person.Gender + " " + person.Age);
        }
    }
}

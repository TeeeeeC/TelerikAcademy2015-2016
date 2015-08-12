namespace _02.PersonClass
{
    using System;

    public class PersonClassTest
    {
        public static void Main()
        {
            PersonGenerator person = new PersonGenerator();
            person.Generate(15);
            person.Generate(16);
        }
    }
}

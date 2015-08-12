namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Hvak");
        }
    }
}

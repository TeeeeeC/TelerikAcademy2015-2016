namespace _03.AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Miauuuu");
        }
    }
}

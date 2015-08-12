namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestMain
    {
        public static void Main()
        {
            var animals = new List<Animal>();
            animals.Add(new Cat("Tom", 2, "male"));
            animals.Add(new Frog("Kasandra", 3, "female"));
            animals.Add(new Dog("Djoni", 5, "male"));
            animals.Add(new Cat("Gosho", 3, "male"));
            animals.Add(new Frog("Rapuncel", 8, "female"));
            animals.Add(new Dog("Kira", 2, "female"));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name + " is " + animal.Age + " years old and is " + animal.Sex);
            }
            Console.WriteLine();

            TomCat[] tomCats = new TomCat[3] { new TomCat("Tom", 2, "male"), new TomCat("Gosho", 3, "male"), new TomCat("Kuncho", 7, "male") };
            Kittens[] kittenCats = new Kittens[2] { new Kittens("Lora", 2, "female"), new Kittens("Zori", 3, "female") };
            Frog[] frogs = new Frog[3] { new Frog("Tom", 5, "male"), new Frog("Gosho", 8, "male"), new Frog("Kuncho", 7, "male") };
            Dog[] dogs = new Dog[2] { new Dog("Tom", 5, "male"), new Dog("Gosho", 8, "male") };

            Console.WriteLine(tomCats.Average(x => x.Age));
            Console.WriteLine(kittenCats.Average(x => x.Age));
            Console.WriteLine(frogs.Average(x => x.Age));
            Console.WriteLine(dogs.Average(x => x.Age));
        }
    }
}

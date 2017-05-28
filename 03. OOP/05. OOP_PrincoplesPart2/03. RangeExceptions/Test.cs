namespace _03.RangeExceptions
{
    using System;

    public class Test
    {
        public static void Main()
        {
            try
            {
                Person person = new Person("Pesho", 100, new DateTime(1988, 3, 3));
                Console.WriteLine(person.Birthday);
            }
            catch(InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}", ex.InvalidRangeDescription);
            }
        }
    }
}

namespace _01.StringBuilderSubstringExtension
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    using Extensions;

    public class TestExtensionMethods
    {
        static void Main()
        {
            string str = "Pesho Todorov Nikolov";
            StringBuilder sb = new StringBuilder(str);

            var subStringBuiled = sb.Substring(6, 7);
            Console.WriteLine(subStringBuiled);

            IEnumerable<decimal> collection = new List<decimal>() { 1, 2, -20, 4, 5 };
            Console.WriteLine(collection.Sum());
            Console.WriteLine(collection.Product());
            Console.WriteLine(collection.Min());
            Console.WriteLine(collection.Max());
            Console.WriteLine(collection.Average());
        }
    }
}

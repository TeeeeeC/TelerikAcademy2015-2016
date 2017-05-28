namespace DataStructuresEfficiency.ConsoleClient
{
    using System;

    using TaskCalculator;

    public class Startup
    {
        private const string FilePath = @"..\..\students.txt";

        private static void Main()
        {
            var taskCalculator = new TaskCalculator();

            // 1.
            taskCalculator.PrintCoursesWithStudents(FilePath);

            Console.WriteLine();

            // 2.
            taskCalculator.FindArticleInPriceRange();

            Console.WriteLine();

            // 3.
            taskCalculator.TestBiDictionary();
        }
    }
}

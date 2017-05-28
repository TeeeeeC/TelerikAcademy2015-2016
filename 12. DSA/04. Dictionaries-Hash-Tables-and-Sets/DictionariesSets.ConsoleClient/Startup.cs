namespace DictionariesSets.ConsoleClient
{
    using System;
    using TasksCalculator;

    public class Startup
    {
        private const int Count = 100;

        private static double[] numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

        private static string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

        private static string path = @"../../words.txt";

        public static void Main()
        {
            var taskCalculator = new TasksCalculator();

            // 1.
            taskCalculator.CountDoubleValuesInArray(numbers);

            // 2.
            taskCalculator.ExtractAllElementThatPresentOddTimes(words);

            // 3.
            taskCalculator.CountWordsInTextFile(path);
        }
    }
}

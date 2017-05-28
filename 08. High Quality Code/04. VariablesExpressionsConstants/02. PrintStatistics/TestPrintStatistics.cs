namespace _02.PrintStatistics
{
    using System;

    public class TestPrintStatistics
    {
        public static void Main(string[] args)
        {
            var statistics = new Statistics();
            var array = new double[] { 5, 6, 1 };

            statistics.Print(array);
        }
    }
}

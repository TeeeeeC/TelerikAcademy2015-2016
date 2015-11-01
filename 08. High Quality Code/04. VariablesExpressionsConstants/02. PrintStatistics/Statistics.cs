namespace _02.PrintStatistics
{
    using System;

    public class Statistics
    {
        public void Print(double[] statistics)
        {
            int length = statistics.Length;

            double max = double.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (statistics[i] > max)
                {
                    max = statistics[i];
                }
            }

            this.PrintMax(max);

            double min = double.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (statistics[i] < min)
                {
                    min = statistics[i];
                }
            }

            this.PrintMin(min);

            double sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += statistics[i];
            }

            double average = sum / length;
            this.PrintAverage(average);
        }

        private void PrintAverage(double average)
        {
            Console.WriteLine("Average: {0}", average);
        }

        private void PrintMin(double min)
        {
            Console.WriteLine("Min: {0}", min);
        }

        private void PrintMax(double max)
        {
            Console.WriteLine("Max: {0}", max);
        }
    }
}

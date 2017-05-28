namespace Maths
{
    using System;
    using System.Diagnostics;

    public class SimpleMaths
    {
        const int ITERATION_COUNT = 10000000;

        public static T Sum<T>(int count)
        {
            T sum = (dynamic)int.MinValue;
            for (int i = 0; i < count; i++)
            {
                sum += (dynamic)1;
            }
            return sum;
        }

        public static T Subtract<T>(int count)
        {
            T difference = (dynamic)int.MinValue;
            for (int i = 0; i < count; i++)
            {
                difference -= (dynamic)1;
            }
            return difference;
        }

        public static T Increment<T>(int count)
        {
            T result = (dynamic)int.MinValue;
            for (int i = 0; i < count; i++)
            {
                result += (dynamic)1;
            }

            return result;
        }

        public static T Multiply<T>(int count)
        {
            T result = (dynamic)int.MinValue;
            for (int i = 0; i < count; i++)
            {
                result *= (dynamic)1;
            }

            return result;
        }

        public static T Divide<T>(int count)
        {
            T result = (dynamic)int.MinValue;
            for (int i = 0; i < count; i++)
            {
                result /= (dynamic)1;
            }

            return result;
        }

        public static void Main()
        {
            Console.WriteLine("For int values");
            Stopwatch stopwatchSum = new Stopwatch();
            stopwatchSum.Start();
            int sumInt = SimpleMaths.Sum<int>(ITERATION_COUNT);
            stopwatchSum.Stop();
            Console.WriteLine("Sum: {0}", stopwatchSum.Elapsed);

            Stopwatch stopwatchDiff = new Stopwatch();
            stopwatchDiff.Start();
            int diffInt = SimpleMaths.Subtract<int>(ITERATION_COUNT);
            stopwatchDiff.Stop();
            Console.WriteLine("Difference: {0}", stopwatchDiff.Elapsed);

            Stopwatch stopwatchIncrement = new Stopwatch();
            stopwatchIncrement.Start();
            int incrementInt = SimpleMaths.Increment<int>(ITERATION_COUNT);
            stopwatchIncrement.Stop();
            Console.WriteLine("Increment: {0}", stopwatchIncrement.Elapsed);

            Stopwatch stopwatchMultipley = new Stopwatch();
            stopwatchMultipley.Start();
            int multiInt = SimpleMaths.Multiply<int>(ITERATION_COUNT);
            stopwatchMultipley.Stop();
            Console.WriteLine("Multiply: {0}", stopwatchMultipley.Elapsed);

            Stopwatch stopwatchDivide = new Stopwatch();
            stopwatchDivide.Start();
            int divInt = SimpleMaths.Divide<int>(ITERATION_COUNT);
            stopwatchDivide.Stop();
            Console.WriteLine("Divide: {0}", stopwatchDivide.Elapsed);

            Console.WriteLine();
            Console.WriteLine("For long values");

            Stopwatch stopwatchSumlong = new Stopwatch();
            stopwatchSumlong.Start();
            long sumlong = SimpleMaths.Sum<long>(ITERATION_COUNT);
            stopwatchSum.Stop();
            Console.WriteLine("Sum long: {0}", stopwatchSum.Elapsed);

            Stopwatch stopwatchDifflong = new Stopwatch();
            stopwatchDifflong.Start();
            long difflong = SimpleMaths.Subtract<long>(ITERATION_COUNT);
            stopwatchDifflong.Stop();
            Console.WriteLine("Difference long: {0}", stopwatchDifflong.Elapsed);

            Stopwatch stopwatchIncrementlong = new Stopwatch();
            stopwatchIncrementlong.Start();
            long incrementlong = SimpleMaths.Increment<long>(ITERATION_COUNT);
            stopwatchIncrementlong.Stop();
            Console.WriteLine("Increment long: {0}", stopwatchIncrementlong.Elapsed);

            Stopwatch stopwatchMultipleylong = new Stopwatch();
            stopwatchMultipleylong.Start();
            long multilong = SimpleMaths.Multiply<long>(ITERATION_COUNT);
            stopwatchMultipleylong.Stop();
            Console.WriteLine("Multiply long: {0}", stopwatchMultipleylong.Elapsed);

            Stopwatch stopwatchDividelong = new Stopwatch();
            stopwatchDividelong.Start();
            long divlong = SimpleMaths.Divide<long>(ITERATION_COUNT);
            stopwatchDividelong.Stop();
            Console.WriteLine("Divide long: {0}", stopwatchDividelong.Elapsed);

            Console.WriteLine();
            Console.WriteLine("For float values");

            Stopwatch stopwatchSumFloat = new Stopwatch();
            stopwatchSumFloat.Start();
            float sumFloat = SimpleMaths.Sum<float>(ITERATION_COUNT);
            stopwatchSumFloat.Stop();
            Console.WriteLine("Sum Float: {0}", stopwatchSumFloat.Elapsed);

            Stopwatch stopwatchDiffFloat = new Stopwatch();
            stopwatchDiffFloat.Start();
            float diffFloat = SimpleMaths.Subtract<float>(ITERATION_COUNT);
            stopwatchDiffFloat.Stop();
            Console.WriteLine("Difference Float: {0}", stopwatchDiffFloat.Elapsed);

            Stopwatch stopwatchIncrementFloat = new Stopwatch();
            stopwatchIncrementFloat.Start();
            float incrementFloat = SimpleMaths.Increment<float>(ITERATION_COUNT);
            stopwatchIncrementFloat.Stop();
            Console.WriteLine("Increment Float: {0}", stopwatchIncrementFloat.Elapsed);

            Stopwatch stopwatchMultipleyFloat = new Stopwatch();
            stopwatchMultipleyFloat.Start();
            float multiFloat = SimpleMaths.Multiply<float>(ITERATION_COUNT);
            stopwatchMultipleyFloat.Stop();
            Console.WriteLine("Multiply Float: {0}", stopwatchMultipleyFloat.Elapsed);

            Stopwatch stopwatchDivideFloat = new Stopwatch();
            stopwatchDivideFloat.Start();
            float divFloat = SimpleMaths.Divide<float>(ITERATION_COUNT);
            stopwatchDivideFloat.Stop();
            Console.WriteLine("Divide Float: {0}", stopwatchDivideFloat.Elapsed);

            // For double and decimal the idea is clear :D
        }
    }
}

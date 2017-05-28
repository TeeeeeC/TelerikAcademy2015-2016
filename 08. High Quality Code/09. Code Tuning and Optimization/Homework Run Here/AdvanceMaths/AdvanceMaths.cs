namespace Maths
{
    using System;
    using System.Diagnostics;

    public class AdvanceMaths
    {
        public static T FindSquareRoot<T>(T number)
        {
            T result = (dynamic)Math.Sqrt((dynamic)number);

            return result;
        }

        public static T FindNaturalLogarithm<T>(T number)
        {
            T result = (dynamic)Math.Log((dynamic)number);

            return result;
        }

        public static T FindSin<T>(T number)
        {
            T result = (dynamic)Math.Sin((dynamic)number);

            return result;
        }

        public static void Main()
        {
            Stopwatch stopwatchSquareRootFloat = new Stopwatch();
            stopwatchSquareRootFloat.Start();
            float squareRootResult = (float)AdvanceMaths.FindSquareRoot(45.6565d);
            stopwatchSquareRootFloat.Stop();

            Stopwatch stopwatchNaturalFloat = new Stopwatch();
            stopwatchNaturalFloat.Start();
            float squareNaturalResult = (float)AdvanceMaths.FindNaturalLogarithm(45.6565d);
            stopwatchNaturalFloat.Stop();

            Stopwatch stopwatchSinFloat = new Stopwatch();
            stopwatchSinFloat.Start();
            float squareSinResult = (float)AdvanceMaths.FindSin(45.6565d);
            stopwatchSinFloat.Stop();

            Console.WriteLine("Float square root: {0}", stopwatchSquareRootFloat.Elapsed);
            Console.WriteLine("Float natural: {0}", stopwatchNaturalFloat.Elapsed);
            Console.WriteLine("Float sin: {0}", stopwatchSinFloat.Elapsed);

            Stopwatch stopwatchSquareRootDouble = new Stopwatch();
            stopwatchSquareRootDouble.Start();
            double squareRootResultDouble = AdvanceMaths.FindSquareRoot(45.6565d);
            stopwatchSquareRootDouble.Stop();

            Stopwatch stopwatchNaturalDouble = new Stopwatch();
            stopwatchNaturalDouble.Start();
            double squareNaturalResultDouble = AdvanceMaths.FindNaturalLogarithm(45.6565d);
            stopwatchNaturalDouble.Stop();

            Stopwatch stopwatchSinDouble = new Stopwatch();
            stopwatchSinDouble.Start();
            double squareSinDouble = AdvanceMaths.FindSin(45.6565d);
            stopwatchSinDouble.Stop();

            Console.WriteLine();
            Console.WriteLine("Double square root: {0}", stopwatchSquareRootDouble.Elapsed);
            Console.WriteLine("Double natural: {0}", stopwatchNaturalDouble.Elapsed);
            Console.WriteLine("Double sin: {0}", stopwatchSinDouble.Elapsed);

            Stopwatch stopwatchSquareRootDecimal = new Stopwatch();
            stopwatchSquareRootDecimal.Start();
            decimal squareRootResultDecimal = (decimal)AdvanceMaths.FindSquareRoot(45.6565d);
            stopwatchSquareRootDecimal.Stop();

            Stopwatch stopwatchNaturalDecimal = new Stopwatch();
            stopwatchNaturalDecimal.Start();
            decimal squareNaturalResultDecimal = (decimal)AdvanceMaths.FindNaturalLogarithm(45.6565d);
            stopwatchNaturalDecimal.Stop();

            Stopwatch stopwatchSinDecimal = new Stopwatch();
            stopwatchSinDecimal.Start();
            decimal squareSinDecimal = (decimal)AdvanceMaths.FindSin(45.6565d);
            stopwatchSinDecimal.Stop();

            Console.WriteLine();
            Console.WriteLine("Decimal square root: {0}", stopwatchSquareRootDecimal.Elapsed);
            Console.WriteLine("Decimal natural: {0}", stopwatchNaturalDecimal.Elapsed);
            Console.WriteLine("Decimal sin: {0}", stopwatchSinDecimal.Elapsed);
        }
    }
}

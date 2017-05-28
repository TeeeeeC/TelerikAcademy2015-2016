namespace LinearDataStructures.ConsoleClient
{
    using System.Collections.Generic;

    using Operations;
    using System;

    public class Startup
    {
        private static List<int> sequenceOfNumbers = new List<int> { 1, 2, 2, -3, 4, -4, -4, 6, 6, 7, 8, -8, -8, 8, 9, -9 };

        private static List<int> majorantCollection = new List<int> { 1, 2, 4, 2, 2 };

        private static string[,] matrix = new string[,]
        {
            { "0", "0","0","x","0","x" },
            { "0", "x","0","x","0","x" },
            { "0", "*","x","0","x","0" },
            { "0", "x","0","0","0","0" },
            { "0", "0","0","x","x","0" },
            { "0", "0","0","x","0","x" }
        };

        public static void Main()
        {
            var operation = new Operation();
            operation.CalculateSumAndAverage();
            operation.ReverseIntigers();
            operation.SortIntegersASC();
            operation.FindLongestSubsequenceOfEqualNumbers();
            operation.RemoveAllNegativeNumbers(sequenceOfNumbers);
            operation.RemoveAllNumbersThatOccurOddNumberOfTimes(sequenceOfNumbers);
            operation.CountHowManyTimeNumberOccursInInterval(sequenceOfNumbers);
            operation.FindMajorant(majorantCollection);
            operation.PrintSequence(2);
            operation.FindShortestSeqOfOperationFromNToM(5, 65);
            operation.FillMatrix(matrix, 2, 1);

        }
    }
}

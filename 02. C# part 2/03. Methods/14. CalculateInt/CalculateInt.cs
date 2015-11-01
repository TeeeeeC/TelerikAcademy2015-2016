using System;
using System.Threading;
using System.Globalization;

class CalculateInt
{
    static void Main()
    {
        /*
         Problem 14. Integer calculations
            Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
            Use variable number of arguments.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        CalculateMin(4, 3, -3, 1);
        CalculateMax(4, 3, -3, 1, 8, 1);
        CalculateAvg(4, 3, -3, 1, 8);
        CalculateSum(4, 3, -3);
        CalculateProduct(4, 3, -3, 5);
    }

    static void CalculateProduct(params int[] nums)
    {
        long product = 1;

        foreach (int elem in nums)
            product *= elem;

        Console.WriteLine("Product: {0}", product);
    }

    static void CalculateSum(params int[] nums)
    {
        long sum = 0;

        foreach (int elem in nums)
            sum += elem;

        Console.WriteLine("Sum: {0}", sum);
    }

    static void CalculateAvg(params int[] nums)
    {
        long sum = 0;

        foreach (int elem in nums)
            sum += elem;

        decimal avg = (decimal)sum / nums.Length;

        Console.WriteLine("Avg: {0}", avg);
    }

    static void CalculateMax(params int[] nums)
    {
        int max = nums[0];

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (max < nums[i])
            {
                int temp = max;
                max = nums[i];
                nums[i] = max;
            }
        }

        Console.WriteLine("Max: {0}", max);
    }

    static void CalculateMin(params int[] nums)
    {
        int min = nums[0];

        for(int i = 1; i < nums.Length - 1; i++)
        {
            if (min > nums[i])
            {
                int temp = min;
                min = nums[i];
                nums[i] = min;
            }
        }

        Console.WriteLine("Min: {0}", min);
    }
}

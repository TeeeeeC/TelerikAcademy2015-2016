using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null) 
        {
            throw new ArgumentNullException("The array cannot be null!");
        }

        if (arr.Length == 0) 
        {
            throw new ArgumentOutOfRangeException("The array length must be atleast 1!");
        }

        if (startIndex < 0)
        {
            throw new IndexOutOfRangeException("The startIndex must be positive number or 0!");
        }

        if (startIndex >= arr.Length)
        {
            throw new IndexOutOfRangeException("The startIndex must be smaller than array length!");
        }

        if (startIndex + count >= arr.Length || startIndex + count < 0) 
        {
            throw new IndexOutOfRangeException("The startIndex + count must be between 0 and array length - 1, inclusive!");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException("The string cannot be null!");
        }

        if (count < 0) 
        {
            throw new ArgumentOutOfRangeException("The count must be positive number or 0!");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("The count must be equal or smaller than string length");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException("The number must be positive number bigger than zero!");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ArithmeticException("The number is not prime!");
            }
        }
    }

    public static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 3); // 4
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 2)); // 100

        try
        {
            CheckPrime(23);
            Console.WriteLine("23 is prime.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("23 is not prime", ex.Message);
        }

        try
        {
            CheckPrime(33);
            Console.WriteLine("33 is prime.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("33 is not prime", ex.Message);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(99), // 100
            new SimpleMathExam(1),
            new CSharpExam(1), // 0
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
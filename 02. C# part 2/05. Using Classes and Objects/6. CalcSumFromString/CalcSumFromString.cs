using System;
using System.Collections.Generic;
class CalcSumFromString
{
    static void Main()
    {
        /*
         Problem 6. Sum integers
            You are given a sequence of positive integer values written into a string, separated by spaces.
            Write a function that reads these values from given string and calculates their sum.
         */
        List<int> numbers = new List<int>();
        string sequenceOfPosInteg = "43 68 9 23 318";
        int i = -1;
        int startIndex = 0, len = 0; ;

        do
        {
            i++;

            if (sequenceOfPosInteg[i] == ' ' || i == sequenceOfPosInteg.Length - 1)
            {
                string numStr = sequenceOfPosInteg.Substring(startIndex, len);
                int num = Convert.ToInt32(numStr);
                numbers.Add(num);

                startIndex = i + 1;
                len = 0;
            }
            
            len++;

        } while(i != sequenceOfPosInteg.Length - 1);

        int sum = 0;

        foreach(int elem in numbers)
        {
            sum += elem;
        }
        Console.WriteLine("{0} -> sum = {1} ", sequenceOfPosInteg, sum);
    }
}

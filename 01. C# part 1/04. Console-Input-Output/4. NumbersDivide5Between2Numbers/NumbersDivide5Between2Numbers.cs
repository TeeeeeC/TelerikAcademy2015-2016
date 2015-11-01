using System;
using System.Collections.Generic;

class NumbersDivide5Between2Numbers
{
    static void Main()
    {
        /*
         Problem 11.* Numbers in Interval Dividable by Given Number
            Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
            that the reminder of the division by 5 is 0.
         */
        Console.WriteLine("");
        Console.Write(" First positive number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write(" Second positive number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int currNum = firstNumber;
        int counter = 0;
        List<int> nums = new List<int>();

        while (currNum <= secondNumber)
        {
            if (currNum %5 == 0)
            {
                counter++;
                nums.Add(currNum);
                currNum += 5;
            }
            else
            {
                if (counter > 0)
                {
                    currNum += 5;
                    continue;
                }

                currNum++;
            }
        }

        Console.WriteLine(counter);

        if (counter > 0)
        {
            foreach (int item in nums)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }    
    }
}


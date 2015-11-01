using System;

class CheckOddAndEvenProduct
{
    static void Main()
    {
        /*
         Problem 10. Odd and Even Product
            You are given n integers (given in a single line, separated by a space).
            Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
         */
        Console.Write("Sequence of int nums: ");
        string nums = Console.ReadLine();
        string[] list = nums.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < list.Length; i++)
        {
            int num = Convert.ToInt32(list[i]);
            
            if(i %2 == 0)
            {
                oddProduct *= num;
            }
            else
            {
                evenProduct *= num;
            }

        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0} = {1}", oddProduct, evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} = {1}", oddProduct, evenProduct);
        }
    }
}
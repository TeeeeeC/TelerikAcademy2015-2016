using System;

class CompareArrays
{
    static void Main()
    {
        /*
         Problem 2. Compare arrays
            Write a program that reads two integer arrays from the console and compares them element by element.
         */
        int lenOfFirstArr = 0, lenOfSecondArr = 0;

        Console.Write("Lenght of first array: ");
        string text = Console.ReadLine();
        int.TryParse(text, out lenOfFirstArr);

        if (lenOfFirstArr < 1)
        {
            lenOfFirstArr = 10; //If user enter letter or negative number
        }

        Console.Write("Lenght of second array: ");
        text = Console.ReadLine();
        int.TryParse(text, out lenOfSecondArr);

        if (lenOfSecondArr < 1)
        {
            lenOfSecondArr = 10; //If user enter letter or negative number
        }

        int[] firstArr = new int[lenOfFirstArr];
        int[] secondArr = new int[lenOfSecondArr];

        int num = 0;

        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Enter number of first array: ");
            text = Console.ReadLine();
            int.TryParse(text, out num);
            firstArr[i] = num;
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write("Enter number of second array: ");
            text = Console.ReadLine();
            int.TryParse(text, out num);
            secondArr[i] = num;
        }

        if (lenOfFirstArr != lenOfSecondArr)
        {
            Console.WriteLine("The arrays are not equal!");
        }
        else
        {
            int countEqualNums = 0;

            for (int i = 0; i < lenOfFirstArr; i++)
            {
                if(firstArr[i] == secondArr[i])
                {
                    countEqualNums++;

                    if (countEqualNums == lenOfFirstArr)
                    {
                        Console.WriteLine("The arrays are equal!");
                    }
                }
                else
                {
                    Console.WriteLine("The arrays are not equal!");
                    break;
                }
            }
        }
    }
}
using System;

class Compare2CharArr
{
    static void Main()
    {
        /*
         Problem 3. Compare char arrays
            Write a program that compares two char arrays lexicographically (letter by letter).
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

        char[] firstArr = new char[lenOfFirstArr];
        char[] secondArr = new char[lenOfSecondArr];

        char letter =  ' ';

        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Enter letter of first array: ");
            text = Console.ReadLine();
            letter = text[0];
            firstArr[i] = letter;
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write("Enter letter of second array: ");
            text = Console.ReadLine();
            letter = text[0];
            secondArr[i] = letter;
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
                if (firstArr[i] == secondArr[i])
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

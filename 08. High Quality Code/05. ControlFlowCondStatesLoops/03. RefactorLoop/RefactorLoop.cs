namespace _03.RefactorLoop
{
    using System;

    public class RefactorLoop
    {
        public const int SEARCHED_NUMBER = 666;
        public const int ARRAY_LENGTH = 100;

        public static void Main(string[] args)
        {
            var numbers = new int[ARRAY_LENGTH];
            var foundNumber = false;
            for (int index = 0; index < ARRAY_LENGTH; index++)
            {
                if (index % 10 == 0)
                {
                    PrintNumber(numbers[index]);
                    foundNumber = FoundNumber(numbers[index]);
                }
                else
                {
                    PrintNumber(numbers[index]);
                }
            }

            // More code here
            if (foundNumber)
            {
                Console.WriteLine("Value Found");
            }
        }

        private static bool FoundNumber(int number)
        {
            var isFound = false;
            if (number == SEARCHED_NUMBER)
            {
                isFound = true;
            }

            return isFound;
        }

        private static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }
    }
}

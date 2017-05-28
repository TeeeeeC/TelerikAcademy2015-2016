namespace _4._5_RefactorFifthTaskCSharp1
{
    using System;
    using System.Text;

    public class BitsToBits
    {
        public const char ZERO_SYMBOL = '0';
        public const char ONE_SYMBOL = '1';

        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            PrintAlgorithmResult(rows);
        }

        private static void PrintAlgorithmResult(int rows)
        {
            StringBuilder sequenceOfDigits = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(currentNumber, 2).PadLeft(30, '0');
                for (int j = 0; j < binaryNumber.Length; j++)
                {
                    var currDigit = binaryNumber[j];
                    sequenceOfDigits.Append(currDigit);
                }
            }

            string binaryText = sequenceOfDigits.ToString();

            int currZerosCount = 1;
            int maxZerosCount = 1;
            char digit = binaryText[0];
            for (int i = 1; i < binaryText.Length; i++)
            {
                if (digit == ZERO_SYMBOL && binaryText[i] == ZERO_SYMBOL)
                {
                    currZerosCount++;

                    if (currZerosCount > maxZerosCount)
                    {
                        maxZerosCount = currZerosCount;
                    }
                }
                else
                {
                    currZerosCount = 1;
                }

                digit = binaryText[i];
            }

            //// For Ones
            int currOnesCount = 1;
            int maxOnesCount = 1;
            digit = binaryText[0];
            for (int i = 1; i < binaryText.Length; i++)
            {
                if (digit == ONE_SYMBOL && binaryText[i] == ONE_SYMBOL)
                {
                    currOnesCount++;

                    if (currOnesCount > maxOnesCount)
                    {
                        maxOnesCount = currOnesCount;
                    }
                }
                else
                {
                    currOnesCount = 1;
                }

                digit = binaryText[i];
            }

            //// Chech if max count of zeros is zero
            int zeroesCount = 0;
            for (int i = 0; i < binaryText.Length; i++)
            {
                if (binaryText[i] == ZERO_SYMBOL)
                {
                    zeroesCount++;

                    if (zeroesCount == binaryText.Length)
                    {
                        maxOnesCount = 0;
                    }
                }
                else
                {
                    break;
                }
            }

            //// Check if max count of ones is zero
            int onesCount = 0;
            for (int i = 0; i < binaryText.Length; i++)
            {
                if (binaryText[i] == ONE_SYMBOL)
                {
                    onesCount++;
                    if (onesCount == binaryText.Length)
                    {
                        maxZerosCount = 0;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(maxZerosCount);
            Console.WriteLine(maxOnesCount);
        }
    }
}

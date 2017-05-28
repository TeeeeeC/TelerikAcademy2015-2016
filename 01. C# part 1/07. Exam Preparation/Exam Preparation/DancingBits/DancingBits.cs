using System;
using System.Text;

class DancingBits
{
    static void Main()
    {
        int sequenceOfEqualElem = int.Parse(Console.ReadLine());
        int nums = int.Parse(Console.ReadLine());

        StringBuilder binaryText = new StringBuilder();

        for (int i = 0; i < nums; i++)
        {
            int number = int.Parse(Console.ReadLine());
            binaryText.Append(Convert.ToString(number, 2));
        }

        char previosChar = binaryText[0];

        int count = 1;
        int countSeq = 0;

        for (int i = 1; i < binaryText.Length; i++)
        {
            if(previosChar == binaryText[i])
            {
                count++;
            }
            else
            {
                if (sequenceOfEqualElem == count)
                {
                    countSeq++;
                }
                count = 1;
                previosChar = binaryText[i];
            }
        }

        if (sequenceOfEqualElem == count)
        {
            countSeq++;
        }

        Console.WriteLine(countSeq);
    }
}
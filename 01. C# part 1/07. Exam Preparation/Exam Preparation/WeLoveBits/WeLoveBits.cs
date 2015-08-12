using System;
using System.Collections.Generic;
using System.Text;
class WeLoveBits
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        List<int> results = new List<int>();

        for (int i = 0; i < numbers; i++)
        {
            int currNum = int.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(currNum, 2);

            for (int j = binaryNum.Length - 1; j >= 0; j--)
            {
                sb.Append(binaryNum[j]);
            }

            results.Add(Convert.ToInt32(sb.ToString(), 2));
            sb.Clear();
        }

        foreach(int num in results)
        {
            Console.WriteLine(num);
        }
    }
}
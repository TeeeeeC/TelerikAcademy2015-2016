using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class BunnyFactory
{
    static void Main()
    {
        var input = new List<int>();
        int num = 0;
        do
        {
            string currNum = Console.ReadLine();
            if (int.TryParse(currNum, out num))
                input.Add(num);
            else
                break;
        } while (true);

        var result = Algorithm(input);

        for (int i = 0; i < result.Count - 1; i++)
        {
            Console.Write("{0} ", result[i]);
        }
        Console.WriteLine(result[result.Count - 1]);

    }

    private static List<int> Algorithm(List<int> input)
    {
        int endIndexCage = 1;
        int steps = 1;
        while (true)
        {
            var sb = new StringBuilder();
            var product = new BigInteger();
            product = 1;

            long sum = 0;

            int startIndexCage = 0;
            for (; startIndexCage < endIndexCage; startIndexCage++)
            {
                if (startIndexCage < input.Count)
                {
                    sum += input[startIndexCage];
                }
                else
                {
                    return input;
                }
            }

            if (sum > input.Count - endIndexCage)
            {
                return input;
            }

            long nextSumStages = sum;
            sum = 0;
            for (; startIndexCage < nextSumStages + steps; startIndexCage++)
            {
                sum += input[startIndexCage];
                product *= input[startIndexCage];
            }

            sb.AppendLine(sum.ToString());
            sb.AppendLine(product.ToString());
            for (; startIndexCage < input.Count; startIndexCage++)
            {
                sb.AppendLine(input[startIndexCage].ToString());
            }

            input.Clear();
            for (int i = 0; i < sb.Length; i++)
            {
                if(sb[i] == '0' || sb[i] == '1')
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] != '\r' && sb[i] != '\n')
                {
                    input.Add((int)(sb[i] - '0'));
                }
            }
            endIndexCage++;
            steps++;

        }
    }
}

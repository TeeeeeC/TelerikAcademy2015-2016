namespace AplusBOfN
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var expression = Console.ReadLine();
            var newLine = Console.ReadLine();
            var power = int.Parse(Console.ReadLine());

            if (power > 1)
            {
                var coeff = FindCoeff(power);
                var result = new StringBuilder();
                result.Append(string.Format("({0}^{1})+", expression[1], power));
                for (int i = 1; i < coeff.Count - 1; i++)
                {
                    result.Append(string.Format("{0}({1}^{2})({3}^{4})+",
                        coeff[i], expression[1], power - i, expression[3], i));
                }
                result.Append(string.Format("({0}^{1})", expression[3], power));

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("({0}^1)+({1}^1)", expression[1], expression[3]);
            }
        }

        private static List<long> FindCoeff(int power)
        {
            var previousSolution = new List<long>();
            var result = new List<long>();
            result.Add(1);
            result.Add(1);
            for (int i = 2; i <= power; i++)
            {
                previousSolution.Add(1);
                for (int j = 1; j < result.Count; j++)
                {
                    previousSolution.Add(result[j - 1] + result[j]);
                }
                result = new List<long>(previousSolution);
                result.Add(1);
                previousSolution.Clear();
            }

            return result;
        }
    }
}

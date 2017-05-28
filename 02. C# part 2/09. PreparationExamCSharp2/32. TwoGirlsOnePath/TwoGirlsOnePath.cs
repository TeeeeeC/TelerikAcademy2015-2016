using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


class TwoGirlsOnePath
{
    static BigInteger[] flowers;
    static BigInteger collectedFlowersOfMolly = 0;
    static BigInteger collectedFlowersOfDolly = 0;

    static void Main()
    {
        Input();
        var winner = FindWinnerOfGame();

        if(winner == "Molly")
        {
            Console.WriteLine("Molly");
            Console.WriteLine("{0} {1}", collectedFlowersOfMolly, collectedFlowersOfDolly);
        }
        else if (winner == "Dolly")
        {
            Console.WriteLine("Dolly");
            Console.WriteLine("{0} {1}", collectedFlowersOfMolly, collectedFlowersOfDolly);
        }
        else
        {
            Console.WriteLine("Draw");
            Console.WriteLine("{0} {1}", collectedFlowersOfMolly, collectedFlowersOfDolly);
        }
    }

    private static string FindWinnerOfGame()
    {
        string name = string.Empty;
        int mollyIndex = 0;
        int dollyIndex = flowers.Length - 1;


        while (true)
        {
            if (flowers[mollyIndex] == 0 || flowers[dollyIndex] == 0)
            {
                if (flowers[mollyIndex] == 0 && flowers[dollyIndex] == 0)
                {
                    name = "Draw";
                }
                else if (flowers[mollyIndex] == 0)
                {
                    name = "Dolly";
                }
                else if (flowers[dollyIndex] == 0)
                {
                    name = "Molly";
                }

                collectedFlowersOfMolly += flowers[mollyIndex];
                collectedFlowersOfDolly += flowers[dollyIndex];
                break;
            }

            BigInteger currMollyFlower = flowers[mollyIndex];
            BigInteger currDollyFlower = flowers[dollyIndex];

            if (mollyIndex == dollyIndex)
            {
                flowers[mollyIndex] = currMollyFlower % 2;
                collectedFlowersOfMolly += currMollyFlower / 2;
                collectedFlowersOfDolly += currDollyFlower / 2;
            }
            else
            {
                flowers[mollyIndex] = 0;
                flowers[dollyIndex] = 0;

                collectedFlowersOfMolly += currMollyFlower;
                collectedFlowersOfDolly += currDollyFlower;
            }

            mollyIndex = (int)((mollyIndex + currMollyFlower) % flowers.Length);
            dollyIndex = (int)((dollyIndex - currDollyFlower) % flowers.Length);
            if(dollyIndex < 0)
            {
                dollyIndex += flowers.Length;
            }
        }
        return name;
    }

    private static void Input()
    {
        string[] numbers = Console.ReadLine().Split(new char[] {' '});
        flowers = new BigInteger[numbers.Length];

        for (int i = 0; i < flowers.Length; i++)
        {
            flowers[i] = BigInteger.Parse(numbers[i]);
        }
    }
}

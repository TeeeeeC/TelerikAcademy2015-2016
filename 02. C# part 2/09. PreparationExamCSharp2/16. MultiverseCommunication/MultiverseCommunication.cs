using System;
using System.Collections.Generic;
using System.Text;



class MultiverseCommunication
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] encryptedNum = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        var numbers = new List<int>();

        for (int i = 0; i < line.Length; i += 3)
        {
            string get3Symbol = line.Substring(i, 3);

            for (int j = 0; j < encryptedNum.Length; j++)
            {
                if (get3Symbol == encryptedNum[j])
                {
                    numbers.Add(j);
                    break;
                }
            }
        }

        int power = numbers.Count - 1;
        long result = 0;

        foreach(int num in numbers)
        {
            result += num * (long)Math.Pow(13, power);
            power--;
        }

        Console.WriteLine(result);
    }
}

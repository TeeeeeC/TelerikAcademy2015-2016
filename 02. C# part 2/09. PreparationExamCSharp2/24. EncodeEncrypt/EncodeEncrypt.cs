using System;
using System.Collections.Generic;
using System.Text;

class EncodeEncrypt
{
    static void Main()
    {
        var message = Console.ReadLine();
        var cypher = Console.ReadLine();

        var encrupted = DecryptedMessage(message, cypher);
        var encoded = EncodeMessage(encrupted.ToString() + cypher);

        Console.WriteLine(encoded + cypher.Length.ToString());
    }

    static StringBuilder DecryptedMessage(string encryptedMessage, string cypher)
    {
        var message = new StringBuilder(encryptedMessage);
        int maxLen = Math.Max(encryptedMessage.Length, cypher.Length);

        for (int i = 0; i < maxLen; i++)
        {
            int messageIndex = i % encryptedMessage.Length;
            int cypherIndex = i % cypher.Length;

            message[messageIndex] = (char)(((message[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
        }
        return message;
    }

    static StringBuilder EncodeMessage(string encodedMassage)
    {
        StringBuilder sb = new StringBuilder();

        int countSeqOfEqualLetters = 1;
        char currSymbol = encodedMassage[0];
        for (int i = 1; i < encodedMassage.Length; i++)
        {
            if (currSymbol == encodedMassage[i])
            {
                countSeqOfEqualLetters++;

                if (i == 1 && encodedMassage.Length == 2)
                {
                    sb.Append(currSymbol);
                    continue;
                }

                if(i == encodedMassage.Length - 1)
                {
                    sb.Append(countSeqOfEqualLetters);
                }
                
            }
            else
            {
                if(countSeqOfEqualLetters == 1)
                {
                    sb.Append(currSymbol);
                }
                else if (countSeqOfEqualLetters == 2)
                {
                    sb.Append(currSymbol, 2);
                }
                else
                {
                    sb.Append(countSeqOfEqualLetters);
                    sb.Append(currSymbol);
                }
                countSeqOfEqualLetters = 1;
            }
            currSymbol = encodedMassage[i];
        }
        sb.Append(encodedMassage[encodedMassage.Length - 1]);
        return sb;
    }
}

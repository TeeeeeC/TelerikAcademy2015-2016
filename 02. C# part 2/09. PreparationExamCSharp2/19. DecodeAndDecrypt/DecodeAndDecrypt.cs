using System;
using System.Collections.Generic;
using System.Text;

class DecodeAndDecrypt
{
    static void Main()
    {
        //Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher

        string cypheredMassage = Console.ReadLine();
        var digits = new List<int>();

        for (int i = cypheredMassage.Length - 1; i >= 0; i--)
        {
            char ch = cypheredMassage[i];
            if(char.IsDigit(ch))
            {
                digits.Add(ch - '0');
            }
            else
            {
                break;
            }
        }

        int lengthOfCypher = digits[0];
        for (int i = 1; i < digits.Count; i++)
        {
            lengthOfCypher += digits[i] * (int) Math.Pow(10, i);
        }

        var encodedMassage = cypheredMassage.Substring(0, cypheredMassage.Length - digits.Count);
        var decodeMessage = EncodeMessage(encodedMassage);

        var encryptedMessage = decodeMessage.Substring(0, decodeMessage.Length - lengthOfCypher);
        var cypher = decodeMessage.Substring(decodeMessage.Length - lengthOfCypher, lengthOfCypher);

        var message = DecryptedMessage(encryptedMessage, cypher);

        Console.WriteLine(message);
    }

    static string DecryptedMessage(string encryptedMessage, string cypher)
    {
        var message = new StringBuilder(encryptedMessage);
        int maxLen = Math.Max(encryptedMessage.Length, cypher.Length);

        for (int i = 0; i < maxLen; i++)
        {
            int messageIndex = i % encryptedMessage.Length;
            int cypherIndex = i % cypher.Length;

            message[messageIndex] = (char) (((message[messageIndex] - 'A')^(cypher[cypherIndex] - 'A')) + 'A');
        }
        return message.ToString();
    }

    static string EncodeMessage(string encodedMassage)
    {
        StringBuilder sb = new StringBuilder();
        var digits = new List<int>();

        int countDigits = 0;
        foreach (var ch in encodedMassage)
        {
            if(char.IsDigit(ch))
            {
                countDigits++;
                digits.Add(ch - '0');
            }
            else
            {
                if(countDigits == 0)
                {
                    sb.Append(ch);
                }
                else
                {
                    countDigits = 0;
                    for (int i = 0; i < digits.Count; i++)
                    {
                        countDigits += digits[i] * (int)Math.Pow(10, digits.Count - i - 1);
                    }

                    for (int i = 0; i < countDigits; i++)
                    {
                        sb.Append(ch);
                    }
                    countDigits = 0;
                }
            }
        }
        return sb.ToString();
    }
}

using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string textOfDigits = Console.ReadLine();

        int sum = 0, counter = 0, digit = 0;

        for (int i = 0; i < textOfDigits.Length; i++)
        {
            if (char.IsDigit(textOfDigits, i))
            {
                digit = (int)textOfDigits[i] - 48;

                if (i % 2 == 1)
                {
                    sum += digit;
                    counter++;
                }
            }        
        }

        Console.WriteLine("{0} {1}", counter, sum);
    }
}

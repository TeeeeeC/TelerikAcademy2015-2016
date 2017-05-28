namespace _4._2_RefactorSecondTaskCSharp1
{
    using System;

    public class TextToNumber
    {
        private static char[] symbols = { '@', '0', 'A', 'a' };

        public static void Main(string[] args)
        {
            int numberForParse = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            long convertedTextToNumber = ConvertTextToNumber(text, numberForParse);

            Console.WriteLine(convertedTextToNumber);
        }

        private static long ConvertTextToNumber(string text, int numberForParse)
        {
            if (numberForParse < 0)
            {
                numberForParse = 2001;
            }

            long convertedTextToNumber = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == symbols[0])
                {
                    return convertedTextToNumber;
                }
                else if (char.IsDigit(symbol))
                {
                    convertedTextToNumber *= symbol - symbols[1];
                }
                else if (char.IsUpper(symbol))
                {
                    convertedTextToNumber += symbol - symbols[2];
                }
                else if (char.IsLower(symbol))
                {
                    convertedTextToNumber += symbol - symbols[3];
                }
                else
                {
                    convertedTextToNumber %= numberForParse;
                }
            }

            return -1;
        }
    }
}

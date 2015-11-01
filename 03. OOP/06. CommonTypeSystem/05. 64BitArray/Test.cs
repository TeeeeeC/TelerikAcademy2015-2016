namespace _05._64BitArray
{
    using System;

    public class Test
    {
        public static void Main()
        {
            BitArray64 number = new BitArray64(123);
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(number[5]);
            Console.WriteLine(number[59]);
            number[63] = 0;
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            BitArray64 number1 = new BitArray64(123);
            BitArray64 number2 = new BitArray64(123);
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1.GetHashCode());
            Console.WriteLine(number1.Equals(number2));
            //Console.WriteLine(number2[-1]);
        }
    }
}

using System;

class Sheets
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int[] arr = { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if(num >= arr[i])
            {
                num -= arr[i];
            }
            else
            {
                Console.WriteLine("A{0}", i);
            }
        }
    }
}

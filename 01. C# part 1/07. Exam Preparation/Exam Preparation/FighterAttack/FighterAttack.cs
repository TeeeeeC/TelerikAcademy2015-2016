using System;

class FighterAttack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx1 = int.Parse(Console.ReadLine());
        int fy1 = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        if (px1 > px2)
        {
            int temp = px1;
            px1 = px2;
            px2 = temp;
        }
        if (py1 < py2)
        {
            int temp = py1;
            py1 = py2;
            py2 = temp;
        }

        fx1 += d;

        int result = 0;

        if (fx1 >= px1 && fx1 <= px2 && fy1 <= py1 && fy1 >= py2)
        {
            result += 100;
        }
        if (fx1 >= px1 && fx1 <= px2 && fy1 + 1 <= py1 && fy1 + 1 >= py2)
        {
            result += 50;
        }
        if (fx1 >= px1 && fx1 <= px2 && fy1 - 1 <= py1 && fy1 - 1 >= py2)
        {
            result += 50;
        }
        if (fx1 + 1 >= px1 && fx1 + 1 <= px2 && fy1 <= py1 && fy1 >= py2)
        {
            result += 75;
        }

        Console.WriteLine("{0}%", result);
    }
}

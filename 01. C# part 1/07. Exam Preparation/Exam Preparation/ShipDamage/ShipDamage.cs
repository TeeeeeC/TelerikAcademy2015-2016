using System;

class ShipDamage
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int catapultx1 = int.Parse(Console.ReadLine());
        int catapulty1 = int.Parse(Console.ReadLine());
        int catapultx2 = int.Parse(Console.ReadLine());
        int catapulty2 = int.Parse(Console.ReadLine());
        int catapultx3 = int.Parse(Console.ReadLine());
        int catapulty3 = int.Parse(Console.ReadLine());

        if (sx1 > sx2)
        {
            int temp = sx1;
            sx1 = sx2;
            sx2 = temp;
        }
        if (sy1 < sy2)
        {
            int temp = sy1;
            sy1 = sy2;
            sy2 = temp;
        }


        catapulty1 = 2 * h - catapulty1;
        catapulty2 = 2 * h - catapulty2;
        catapulty3 = 2 * h - catapulty3;

        int result = 0;

        if ((catapultx1 == sx1 && catapulty1 == sy1) || (catapultx1 == sx2 && catapulty1 == sy2)
            || (catapultx1 == sx1 && catapulty1 == sy2) || (catapultx1 == sx2 && catapulty1 == sy1))
        {
            result += 25;
        }
        if ((catapultx2 == sx1 && catapulty2 == sy1) || (catapultx2 == sx2 && catapulty2 == sy2)
            || (catapultx2 == sx1 && catapulty2 == sy2) || (catapultx2 == sx2 && catapulty2 == sy1))
        {
            result += 25;
        }
        if ((catapultx3 == sx1 && catapulty3 == sy1) || (catapultx3 == sx2 && catapulty3 == sy2)
            || (catapultx3 == sx1 && catapulty3 == sy2) || (catapultx3 == sx2 && catapulty3 == sy1))
        {
            result += 25;
        }

        if (catapultx1 > sx1 && catapulty1 < sy1 && catapultx1 < sx2 && catapulty1 > sy2)
        {
            result += 100;
        }
        if (catapultx2 > sx1 && catapulty2 < sy1 && catapultx2 < sx2 && catapulty2 > sy2)
        {
            result += 100;
        }
        if (catapultx3 > sx1 && catapulty3 < sy1 && catapultx3 < sx2 && catapulty3 > sy2)
        {
            result += 100;
        }

        if ((catapultx1 == sx1 && catapulty1 < sy1 && catapulty1 > sy2) || (catapultx1 == sx2 && catapulty1 < sy1 && catapulty1 > sy2)
            || (catapulty1 == sy1 && catapultx1 > sx1 && catapultx1 < sx2) || (catapulty1 == sy2 && catapultx1 > sx1 && catapultx1 < sx2))
        {
            result += 50;
        }
        if ((catapultx2 == sx1 && catapulty2 < sy1 && catapulty2 > sy2) || (catapultx2 == sx2 && catapulty2 < sy1 && catapulty2 > sy2)
            || (catapulty2 == sy1 && catapultx2 > sx1 && catapultx2 < sx2) || (catapulty2 == sy2 && catapultx2 > sx1 && catapultx2 < sx2))
        {
            result += 50;
        }
        if ((catapultx3 == sx1 && catapulty3 < sy1 && catapulty3 > sy2) || (catapultx3 == sx2 && catapulty3 < sy1 && catapulty3 > sy2)
            || (catapulty3 == sy1 && catapultx3 > sx1 && catapultx3 < sx2) || (catapulty3 == sy2 && catapultx3 > sx1 && catapultx3 < sx2))
        {
            result += 50;
        }

        Console.WriteLine("{0}%", result);
    }
}
using System;
using System.Threading;
using System.Globalization;

class FindSurfaceOfTriangle
{
    static void Main()
    {
        /*
         Problem 4. Triangle surface
            Write methods that calculate the surface of a triangle by given:
            Side and an altitude to it;
            Three sides;
            Two sides and an angle between them;
            Use System.Math.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("                 Surface of Triangle\n\n");
        Console.WriteLine("         1. Side and an altitude of it");
        Console.WriteLine("         2. Three sides");
        Console.WriteLine("         3. Two sides and an angle between them\n");

        Console.Write("         Please choose number from menu: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (num)
        {
            case 1: Formula1(); break;
            case 2: Formula2(); break;
            case 3: Formula3(); break;
        }

        Console.WriteLine();
    }

    public static void Formula1 ()
    {
        Console.Write("         Side = ");
        int side = int.Parse(Console.ReadLine());

        Console.Write("         Altitude = ");
        int altitude = int.Parse(Console.ReadLine());

        float surface1 = (float) (side * altitude) / 2;

        Console.WriteLine("         Surface = {0:F2}", surface1);
    }

    public static void Formula2()
    {
        Console.Write("         SideA = ");
        int sideA = int.Parse(Console.ReadLine());

        Console.Write("         SideB = ");
        int sideB = int.Parse(Console.ReadLine());

        Console.Write("         SideC = ");
        int sideC = int.Parse(Console.ReadLine());

        float p = (float) (sideA + sideB + sideC) / 2;
        float expression = (float) (p * (p - sideA) * (p - sideB) * (p - sideC));

        float surface2 = (float) Math.Sqrt(expression);

        Console.WriteLine("         Surface = {0:F2}", surface2);
    }

    public static void Formula3()
    {
        Console.Write("         Side1 = ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("         Side2 = ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("         Angle in degrees = ");
        int degrees = int.Parse(Console.ReadLine());
        float angle = (float) (Math.PI * degrees) / 180;

        float surface3 = (float)(side1 * side2 * Math.Sin(angle)) / 2;

        Console.WriteLine("         Surface = {0:F2}", surface3);
    }
}

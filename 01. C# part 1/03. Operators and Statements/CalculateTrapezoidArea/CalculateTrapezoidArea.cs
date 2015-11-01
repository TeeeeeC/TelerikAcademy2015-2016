using System;

    class CalculateTrapezoidArea
    {
        static void Main()
        {
            /*
             Problem 9. Trapezoids
                Write an expression that calculates trapezoid's area by given sides a and b and height h.
             */
            Console.Write("Insert a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insert b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insert h: ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) * h) / 2;

            Console.WriteLine("\nTrapezoid's area is {0}!\n", area);
        }
    }


using System;

class QuadraticEquation
{
    static void Main()
    {
        /*
         Problem 6. Quadratic Equation
            Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
         */
        Console.WriteLine(" Quadratic Equation \n");
        double D = -1, a = 0, b = 0, c = 0;

        Console.Write(" Cofficient a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write(" Cofficient b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write(" Cofficient c: ");
        c = double.Parse(Console.ReadLine());
        D = (b * b) - (4 * a * c);

        if (D < 0)
        {
            Console.WriteLine("\n No real roots(D < 0)!");
                return;
        }

        double x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
        double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);

        Console.WriteLine(" The real roots are x1 = {0} and x2 = {1}!", x1, x2);
  
    }
}


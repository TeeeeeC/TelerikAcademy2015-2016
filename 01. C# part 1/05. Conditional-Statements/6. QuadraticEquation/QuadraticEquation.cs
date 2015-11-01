using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine(" Quadratic Equation \n");
        int a = 0, b = 0, c = 0, D = -1;
        string number1 = "", number2 = "", number3 = "";

        do
        {
            Console.Write(" Cofficient a: ");
            number1 = Console.ReadLine();
            Console.Write(" Cofficient b: ");
            number2 = Console.ReadLine();
            Console.Write(" Cofficient c: ");
            number3 = Console.ReadLine();
            
            if(((int.TryParse(number1, out a))) && (int.TryParse(number2, out b)) && (int.TryParse(number3, out c)))
            {
                D = (b * b) - (4 * a * c);
            }

            if (D < 0)
            {
                Console.WriteLine("\n Insert the coefficient again (D < 0 or wrong numbers)! \n");
            }
        }while ((D < 0) || ((!(int.TryParse(number1, out a))) || (!(int.TryParse(number2, out b))) || (!(int.TryParse(number3, out c)))));

        if (D > 0)
        {
            double x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
            double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine(" The real roots are x1 = {0} and x2 = {1}!", x1, x2);
        }
        else
        {
            double x0 = (-b) / (2 * a);

            Console.WriteLine(" The real root is x0 = {0}!", x0);
        }
    }
}



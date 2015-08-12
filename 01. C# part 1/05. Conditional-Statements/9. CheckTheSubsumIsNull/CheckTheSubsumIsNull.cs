using System;

class CheckTheSubsumIsNull
{
    static void Main()
    {
        /*
         Problem 12.* Zero Subset
            We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
            Assume that repeating the same subset several times is not a problem.
         */
        Console.WriteLine(" Check the subsum is 0 \n");
        int a = 0, b = 0, c = 0, d = 0, e = 0;
        string number1 = "", number2 = "", number3 = "", number4 = "", number5 = "";

        do
        {
            Console.Write(" Insert number 1: ");
            number1 = Console.ReadLine();
            Console.Write(" Insert number 2: ");
            number2 = Console.ReadLine();
            Console.Write(" Insert number 3: ");
            number3 = Console.ReadLine();
            Console.Write(" Insert number 4: ");
            number4 = Console.ReadLine();
            Console.Write(" Insert number 5: ");
            number5 = Console.ReadLine();


        } while ((!(int.TryParse(number1, out a))) || (!(int.TryParse(number2, out b))) || (!(int.TryParse(number3, out c))) || (!(int.TryParse(number4, out d))) || (!(int.TryParse(number5, out e))));

        Console.WriteLine();
        Console.WriteLine(" The numbers are ({0}, {1}, {2}, {3}, {4})", a, b, c, d, e);
        Console.WriteLine();

        int result = 1; 

        for (int i = 1; i < 20; i++)
        {
            switch (i)
            {
                case 1:
                        if (((a) + (b) + (c) + (d) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2}, {3}, {4} -> ({5}) + ({6}) + ({7}) + ({8}) + ({9}) = 0", a, b, c, d, e, a, b, c, d, e);
                            result = (a) + (b) + (c) + (d) + (e);
                            i = 19;
                        } break;
                case 2: 
                        if (((a) + (b) + (c) + (d)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2}, {3} -> ({4}) + ({5}) + ({6}) + ({7}) = 0", a, b, c, d, a, b, c, d);
                            result = (a) + (b) + (c) + (d);
                        } break;
                case 3: 
                        if (((a) + (c) + (d) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2}, {3} -> ({4}) + ({5}) + ({6}) + ({7}) = 0", a, c, d, e, a, c, d, e);
                            result = (a) + (c) + (d) + (e);
                        } break;
                case 4: 
                        if (((a) + (b) + (c)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2} -> ({3}) + ({4}) + ({5}) = 0", a, b, c, a, b, c);
                            result = (a) + (b) + (c);
                        } break;
                case 5: 
                        if (((a) + (c) + (d)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2} -> ({3}) + ({4}) + ({5}) = 0", a, c, d, a, c, d);
                            result = (a) + (c) + (d);
                        } break;
                case 6: 
                        if (((a) + (d) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2} -> ({3}) + ({4}) + ({5}) = 0", a, d, e, a, d, e);
                            result = (a) + (d) + (e);
                        } break;
                case 7: 
                        if (((b) + (c) + (d)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2} -> ({3}) + ({4}) + ({5}) = 0", b, c, d, b, c, d);
                            result = (b) + (c) + (d);
                        } break;
                case 8: 
                        if (((b) + (d) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2} -> ({3}) + ({4}) + ({5}) = 0", b, d, e, b, d, e);
                            result = (b) + (d) + (e);
                        } break;
                case 9: 
                        if (((c) + (d) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1}, {2} -> ({3}) + ({4}) + ({5}) = 0", c, d, e, c, d, e);
                            result = (c) + (d) + (e);
                        } break;
                case 10: 
                        if (((a) + (b)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", a, b, a, b);
                            result = (a) + (b);
                        } break;
                case 11: 
                        if (((a) + (c)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", a, c, a, c);
                            result = (a) + (c);
                        } break;
                case 12: 
                        if (((a) + (d)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", a, d, a, d);
                            result = (a) + (d);
                        } break;
                case 13: 
                        if (((a) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", a, e, a, e);
                            result = (a) + (e);
                        } break;
                case 14: 
                        if (((b) + (c)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", b, c, b, c);
                            result = (b) + (c);
                        } break;
                case 15: 
                        if (((b) + (d)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", b, d, b, d);
                            result = (b) + (d);
                        } break;
                case 16: 
                        if (((b) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", b, e, b, e);
                            result = (b) + (e);
                        } break;
                case 17: 
                        if (((c) + (d)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", c, d, c, d);
                            result = (c) + (d);
                        } break;
                case 18: 
                        if (((c) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", c, e, c, e);
                            result = (c) + (e);
                        } break;
                case 19: 
                        if (((d) + (e)) == 0)
                        {
                            Console.WriteLine(" {0}, {1} -> ({2}) + ({3}) = 0", d, e, d, e);
                            result = (d) + (e);
                        } break;
            } 
        }

        if (result != 0)
        {
            Console.WriteLine(" There are no subset that are equal to 0! ");
            Console.WriteLine();
        }
    }
}


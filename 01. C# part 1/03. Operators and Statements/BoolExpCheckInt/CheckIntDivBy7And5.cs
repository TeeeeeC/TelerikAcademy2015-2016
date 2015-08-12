using System;

class BoolExpCheckInt
{
    static void Main()
    {
        /*
         Problem 3. Divide by 7 and 5
            Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
         */
        Console.WriteLine("Divide Int without remainder by 7 and 5 in the same time");
        Console.Write("Insert integer: ");
        int number = Convert.ToInt32(Console.ReadLine());


        int divide5 = number % 5;
        int divide7 = number % 7;

        bool compareDIVIDE = ((divide5 == 0) && (divide7 == 0));

        if (number == 0)
        {
            compareDIVIDE = false;
        }

        Console.WriteLine(compareDIVIDE);
    }
}
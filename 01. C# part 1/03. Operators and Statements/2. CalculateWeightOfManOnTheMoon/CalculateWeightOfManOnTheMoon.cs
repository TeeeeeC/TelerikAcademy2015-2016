using System;

class CalculateWeightOfManOnTheMoon
{
    static void Main()
    {
        /*
         Problem 2. Gravitation on the Moon
            The gravitational field of the Moon is approximately 17% of that on the Earth.
            Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
         */
        Console.Write("Weight of Man on the Earth: ");
        double weightOfEarth = double.Parse(Console.ReadLine());

        double weightOfMoon = weightOfEarth * 0.17;

        Console.WriteLine("Weight of Man on the Moon: {0}", weightOfMoon);
    }
}

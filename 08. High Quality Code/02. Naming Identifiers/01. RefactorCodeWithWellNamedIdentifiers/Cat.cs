namespace Animal
{
    using System;

    public class Cat
    {
        private const int MAX_COUNT = 6;

        public void Sleep(bool slept)
        {
            string convertedBoolValueToString = slept.ToString();
            Console.WriteLine(convertedBoolValueToString);
        }
    }
}

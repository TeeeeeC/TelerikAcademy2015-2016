namespace _01.Tools
{
    using System;

    using log4net;
    using log4net.Config;

    public class DevelopmentTools
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(DevelopmentTools));

        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            int[] numbers = new int[] { 4, 8, -3 };
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        Log.Info(string.Format("The sqrt from {0} is {1}", numbers[i], Math.Sqrt(numbers[i])));
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Log.Error("The number must be positive!", e);
            }

            Console.WriteLine("Check results in log.txt file in debug folder!!!");
        }
    }
}

namespace _4._1_RefactorFirstTaskCSharp1
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class RefactorPrinting
    {
        public const decimal SHEETS_IN_BOX = 500;

        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal studentsCount = decimal.Parse(Console.ReadLine());
            decimal sheetsCount = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal totalPrice = GetTotalPrice(studentsCount, sheetsCount, price);

            Console.WriteLine("{0:F2}", totalPrice);
        }

        private static decimal GetTotalPrice(decimal studentsCount, decimal sheetsCount, decimal price)
        {
            var amount = ((studentsCount * sheetsCount) / SHEETS_IN_BOX) * price;

            return amount;
        }
    }
}

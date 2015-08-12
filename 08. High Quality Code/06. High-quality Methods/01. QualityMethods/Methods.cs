namespace _01.QualityMethods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (OutRange(sideA, sideB, sideC))
            {
                throw new ArgumentOutOfRangeException("Sides must be positive numbers!");
            }

            if (!ChechIfTwoSidesBiggerThanThird(sideA, sideB, sideC))
            {
                throw new ArithmeticException("Every two sides must be bigger that the third!");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return area;
        }

        public static bool OutRange(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return true;
            }

            return false;
        }

        public static bool ChechIfTwoSidesBiggerThanThird(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC || sideA + sideC > sideB || sideB + sideC > sideA)
            {
                return true;
            }

            return false;
        }

        public static string DigitToWord(int digit)
        {
            try
            {
                switch (digit)
                {
                    case 0: return "zero";
                    case 1: return "one";
                    case 2: return "two";
                    case 3: return "three";
                    case 4: return "four";
                    case 5: return "five";
                    case 6: return "six";
                    case 7: return "seven";
                    case 8: return "eight";
                    case 9: return "nine";
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Digit must be a number between 0 and 9 inclusive!";
            }
        }

        public static long FindMaximalNumber(params long[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("The method require atleast one number!");
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentOutOfRangeException("The array of numbers is empty!");
            }

            var maximalNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximalNumber)
                {
                    maximalNumber = numbers[i];
                }
            }

            return maximalNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="format">The char symbol must be 'f' (float), '%' for percentage or r (real)</param>
        public static void PrintNumberInGivenFormat(double number, char format)
        {
            try
            {
                if (format == 'f')
                {
                    Console.WriteLine("{0:f2}", number);
                }
                else if (format == '%')
                {
                    Console.WriteLine("{0:p0}", number);
                }
                else if (format == 'r')
                {
                    Console.WriteLine("{0,8}", number);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Format must be 'f' (float), '%' for percentage or r (real)");
            }
        }

        public static double CalculcateDistance(double startPointX, double startPointY, double endPointX, double endPointY, out bool isHorizontal, out bool isVertical)
        {
            if (startPointY == endPointY)
            {
                isHorizontal = true;
            }
            else
            {
                isHorizontal = false;
            }

            if (startPointX == endPointX)
            {
                isVertical = true;
            }
            else
            {
                isVertical = false;
            }

            double resultOfExpressionForX = (endPointX - startPointX) * (endPointX - startPointX);
            double resultOfExpressionForY = (endPointY - startPointY) * (endPointY - startPointY);
            double finalResultOfExpressions = resultOfExpressionForX + resultOfExpressionForY;
            double distance = Math.Sqrt(finalResultOfExpressions);

            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToWord(5));

            Console.WriteLine(FindMaximalNumber(5, -1, 3, 2, 14, 2, 3));

            PrintNumberInGivenFormat(1.3, 'f');
            PrintNumberInGivenFormat(0.75, '%');
            PrintNumberInGivenFormat(2.30, 'r');

            bool horizontal, vertical;
            Console.WriteLine(CalculcateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

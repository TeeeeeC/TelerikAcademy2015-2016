namespace _02.RefactorIfStatements
{
    using System;

    public class RefactorIfStates
    {
        public const int MIN_X = 1;
        public const int MAX_X = 10;
        public const int MIN_Y = 3;
        public const int MAX_Y = 8;

        public static void Main(string[] args)
        {
            Potato potato = new Potato();

            //// First statement
            if (potato != null)
            {
                if (potato.HasBeenPeeled && potato.NotRotten) 
                {
                    Cook(potato);
                }
            }

            //// Second statement
            var x = 3;
            var y = 5;
            bool shouldVisitCell = true;
            if (InRange(x, y) && shouldVisitCell)
            {
               VisitCell();
            }
        }

        private static bool InRange(int valueX, int valueY)
        {
            var inRange = false;
            if ((MIN_X <= valueX && valueX <= MAX_X) && (MIN_Y <= valueY && valueY <= MAX_Y))
            {
                inRange = true;
            }

            return inRange;
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}

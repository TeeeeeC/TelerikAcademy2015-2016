namespace _01.SizeClass
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double newWidth, double newHeight)
        {
            this.width = newWidth;
            this.height = newHeight;
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigure)
        {
            var resultOfCosinusFunctionForWidth = Math.Abs(Math.Cos(angleOfTheFigure)) * size.width;
            var resultOfSinusFunctionForWigth = Math.Abs(Math.Sin(angleOfTheFigure)) * size.width;
            var resultOfCosinusFunctionForHeight = Math.Abs(Math.Cos(angleOfTheFigure)) * size.height;
            var resultOfSinusFunctionForHeight = Math.Abs(Math.Sin(angleOfTheFigure)) * size.height;

            var rotatedWidth = resultOfCosinusFunctionForWidth + resultOfSinusFunctionForHeight;
            var rotatedHeight = resultOfSinusFunctionForWigth + resultOfCosinusFunctionForHeight;

            var rotatedSize = new Size(rotatedWidth, rotatedHeight);

            return rotatedSize;
        }
    }
}

namespace _01.SizeClass
{
    using System;

    public class TestSizeClass
    {
        public static void Main(string[] args)
        {
            var size = Size.GetRotatedSize(new Size(5, 6), 45);

            Console.WriteLine(size);
        }
    }
}

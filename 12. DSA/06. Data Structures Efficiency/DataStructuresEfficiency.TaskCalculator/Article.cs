namespace DataStructuresEfficiency.TaskCalculator
{
    using System;

    public class Article : IComparable<Article>
    {
        public string Title { get; set; }

        public string Vendor { get; set; }

        public string Barcode { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article anotherArticle)
        {
            if (this.Price.CompareTo(anotherArticle.Price) > 0)
            {
                return 1;
            }

            if (this.Price.CompareTo(anotherArticle.Price) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}

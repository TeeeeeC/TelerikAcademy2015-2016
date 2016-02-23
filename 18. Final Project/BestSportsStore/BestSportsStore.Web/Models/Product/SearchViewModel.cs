namespace BestSportsStore.Web.Models.Product
{
    using System.Collections.Generic;

    public class SearchViewModel
    {
        public string Category { get; set; }

        public string SubCategory { get; set; }

        public string Brand { get; set; }

        public string Sport { get; set; }

        public IEnumerable<string> Data { get; set; }
    }
}
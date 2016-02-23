namespace BestSportsStore.Web.Models.Product
{
    using System.Collections.Generic;

    public class PaginationViewModel
    {
        public int PagesCount { get; set; }

        public int CurrentPage { get; set; }

        public string Category { get; set; }

        public string SubCategory { get; set; }

        public string Sport { get; set; }

        public string Brand { get; set; }

        public string Query { get; set; }

        public bool Ascending { get; set; }

        public string OrderBy { get; set; }

        public IList<ProductViewModel> Products { get; set; }
    }
}
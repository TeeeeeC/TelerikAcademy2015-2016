namespace BestSportsStore.Web.Areas.Administration.Models
{
    using Web.Models.Product;
    using System.Collections.Generic;

    public class ProductGridViewModel
    {
        public int PagesCount { get; set; }

        public int CurrentPage { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }
    }
}
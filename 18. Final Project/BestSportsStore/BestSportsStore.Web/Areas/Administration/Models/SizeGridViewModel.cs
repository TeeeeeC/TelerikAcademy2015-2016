namespace BestSportsStore.Web.Areas.Administration.Models
{
    using Web.Models.Product;
    using System.Collections.Generic;

    public class SizeGridViewModel
    {
        public int PagesCount { get; set; }

        public int CurrentPage { get; set; }

        public ICollection<SizeViewModel> Sizes { get; set; }
    }
}
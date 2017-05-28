namespace BestSportsStore.Web.Models.Menu
{
    using Brand;
    using Category;
    using Sport;

    using System.Collections.Generic;

    public class MenuViewModel
    {
        public ICollection<CategoryViewModel> Categories { get; set; }

        public ICollection<SportViewModel> Sports { get; set; }

        public ICollection<BrandViewModel> Brands { get; set; }
    }
}
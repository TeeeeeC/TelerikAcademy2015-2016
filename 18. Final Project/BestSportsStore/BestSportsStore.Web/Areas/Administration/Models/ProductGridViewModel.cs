namespace BestSportsStore.Web.Areas.Administration.Models
{
    using Infrastructure.Mapping;
    using Data.Models;
    using Web.Models.Menu.Category;
    using Web.Models.Menu.Brand;
    using Web.Models.Sport;
    using System.ComponentModel.DataAnnotations;

    public class ProductGridViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        [UIHint("CategoriesDropDown")]
        public CategoryViewModel Category { get; set; }

        [UIHint("SubCategoriesDropDown")]
        public SubCategoryViewModel SubCategory { get; set; }

        [UIHint("BrandsDropDown")]
        public BrandViewModel Brand { get; set; }

        [UIHint("SportsDropDown")]
        public SportViewModel Sport { get; set; }
    }
}
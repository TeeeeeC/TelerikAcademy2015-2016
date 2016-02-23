namespace BestSportsStore.Web.Models.Product
{
    using System.Collections.Generic;

    using Infrastructure.Mapping;
    using Data.Models;
    using Comment;
    using Like;
    using Menu.Category;
    using Menu.Brand;
    using Sport;

    public class ProductViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public CategoryViewModel Category { get; set; }

        public SubCategoryViewModel SubCategory { get; set; }

        public BrandViewModel Brand { get; set; }

        public SportViewModel Sport { get; set; }

        public string SizeValues { get; set; }

        public int Quantity { get; set; }

        public ICollection<LikeViewModel> Likes { get; set; }

        public ICollection<SizeViewModel> Sizes { get; set; }
       
        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
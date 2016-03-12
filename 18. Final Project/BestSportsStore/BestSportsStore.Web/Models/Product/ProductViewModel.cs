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
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public CategoryViewModel Category { get; set; }

        public int SubCategoryId { get; set; }

        public SubCategoryViewModel SubCategory { get; set; }

        public int BrandId { get; set; }

        public BrandViewModel Brand { get; set; }

        public int SportId { get; set; }

        public SportViewModel Sport { get; set; }

        public ICollection<LikeViewModel> Likes { get; set; }

        public IList<SizeViewModel> Sizes { get; set; }
       
        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
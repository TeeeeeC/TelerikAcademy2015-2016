namespace BestSportsStore.Web.Models.Product
{
    using System.Collections.Generic;

    using Infrastructure.Mapping;
    using Data.Models;

    public class ProductViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }

        public SubCategory SubCategory { get; set; }

        public Brand Brand { get; set; }

        public Sport Sport { get; set; }

        public ICollection<Like> Likes { get; set; }

        public ICollection<Size> Sizes { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
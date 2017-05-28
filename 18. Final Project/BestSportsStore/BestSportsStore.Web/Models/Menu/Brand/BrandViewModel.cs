namespace BestSportsStore.Web.Models.Menu.Brand
{
    using Infrastructure.Mapping;
    using Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class BrandViewModel : IMapFrom<Brand>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
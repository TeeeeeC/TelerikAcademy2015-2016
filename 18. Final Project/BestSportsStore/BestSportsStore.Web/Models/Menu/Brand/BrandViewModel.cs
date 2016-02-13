namespace BestSportsStore.Web.Models.Menu.Brand
{
    using Infrastructure.Mapping;
    using Data.Models;

    public class BrandViewModel : IMapFrom<Brand>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
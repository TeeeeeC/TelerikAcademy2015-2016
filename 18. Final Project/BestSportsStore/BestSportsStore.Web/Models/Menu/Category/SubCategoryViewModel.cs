namespace BestSportsStore.Web.Models.Menu.Category
{
    using Infrastructure.Mapping;
    using Data.Models;

    public class SubCategoryViewModel : IMapFrom<SubCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
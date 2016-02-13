namespace BestSportsStore.Web.Models.Menu.Category
{
    using System.Collections.Generic;

    using Infrastructure.Mapping;
    using Data.Models;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<SubCategoryViewModel> SubCategories { get; set; }
    }
}
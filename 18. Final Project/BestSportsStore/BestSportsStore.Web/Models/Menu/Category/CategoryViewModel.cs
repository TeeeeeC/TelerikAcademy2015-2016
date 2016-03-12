namespace BestSportsStore.Web.Models.Menu.Category
{
    using System.Collections.Generic;

    using Infrastructure.Mapping;
    using Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<string> SubCategoryNames { get; set; }

        public ICollection<SubCategoryViewModel> SubCategories { get; set; }
    }
}
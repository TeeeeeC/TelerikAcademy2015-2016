namespace BestSportsStore.Web.Models.Menu.Category
{
    using Infrastructure.Mapping;
    using Data.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SubCategoryViewModel : IMapFrom<SubCategory>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<string> CategoryNames { get; set; }
    }
}
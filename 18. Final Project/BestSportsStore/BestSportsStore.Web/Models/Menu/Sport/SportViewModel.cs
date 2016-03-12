namespace BestSportsStore.Web.Models.Sport
{
    using Infrastructure.Mapping;
    using Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class SportViewModel : IMapFrom<Sport>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
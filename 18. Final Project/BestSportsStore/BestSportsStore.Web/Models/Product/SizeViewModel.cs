namespace BestSportsStore.Web.Models.Product
{
    using Data.Models;
    using Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class SizeViewModel : IMapFrom<Size>
    {
        public int Id { get; set; }

        [Required]
        [Range(17, 100)]
        public short Value { get; set; }
    }
}
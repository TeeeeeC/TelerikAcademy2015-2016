namespace BestSportsStore.Web.Models.Product
{
    using Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SizeViewModel : IMapFrom<Size>
    {
        public int Id { get; set; }

        public short Value { get; set; }
    }
}
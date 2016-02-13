namespace BestSportsStore.Web.Models.Sport
{
    using System.Collections.Generic;

    using Infrastructure.Mapping;
    using Data.Models;

    public class SportViewModel : IMapFrom<Sport>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
namespace BestSportsStore.Web.Models.Like
{
    using Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class LikeViewModel : IMapFrom<Like>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }
    }
}
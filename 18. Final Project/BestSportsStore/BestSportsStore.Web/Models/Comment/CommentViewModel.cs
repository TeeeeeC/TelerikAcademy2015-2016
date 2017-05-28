namespace BestSportsStore.Web.Models.Comment
{
    using Data.Models;
    using Infrastructure.Mapping;

    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CommentViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }
       
        [Required]
        [StringLength(500, MinimumLength = 5)]
        [AllowHtml]
        public string Content { get; set; }

        public int ProductId { get; set; }

        public User User { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
namespace TwitterSystem.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using Data.Models;
    
    public class TweetViewModel
    {
        public static Expression<Func<Tweet, TweetViewModel>> TweetView
        {
            get
            {
                return tweet => new TweetViewModel
                {
                    Id = tweet.Id,
                    Text = tweet.Text,
                    TimeStamp = tweet.TimeStamp,
                    LikesCount = tweet.LikesCount,
                    User = tweet.User
                };
            }
        }

        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime TimeStamp { get; set; }

        public int LikesCount { get; set; }

        public User User { get; set; }
    }
}
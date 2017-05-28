namespace TwitterSystem.Services.Data
{
    using System.Linq;

    using TwitterSystem.Data.Models;
    using TwitterSystem.Data.Repositories;

    public class TweetsService : ITweetsService
    {
        private IRepository<Tweet> tweets;

        public TweetsService(IRepository<Tweet> tweets)
        {
            this.tweets = tweets;
        }

        public IQueryable<Tweet> GetAllByUser(string id)
        {
            return this.tweets
                .All()
                .Where(t => t.UserId == id);
        }

        public IQueryable<Tweet> GetByTag(string tag)
        {
            return this.tweets
                .All()
                .Where(t => t.Text.Contains(tag));
        }

        public void Add(Tweet tweet)
        {
            this.tweets.Add(tweet);
            this.tweets.SaveChanges();
        }
    }
}

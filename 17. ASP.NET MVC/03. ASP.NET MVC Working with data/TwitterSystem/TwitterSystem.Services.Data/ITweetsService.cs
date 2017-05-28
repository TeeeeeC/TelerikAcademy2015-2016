namespace TwitterSystem.Services.Data
{
    using System.Linq;
    using TwitterSystem.Data.Models;

    public interface ITweetsService
    {
        IQueryable<Tweet> GetAllByUser(string id);

        IQueryable<Tweet> GetByTag(string tag);

        void Add(Tweet tweet);
    }
}

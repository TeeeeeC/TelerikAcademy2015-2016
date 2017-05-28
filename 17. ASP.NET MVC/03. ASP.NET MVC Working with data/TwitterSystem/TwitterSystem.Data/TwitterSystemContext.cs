namespace TwitterSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using Models;

    public class TwitterSystemContext : IdentityDbContext<User>, ITwitterSystemContext
    {
        public TwitterSystemContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Tweet> Tweets { get; set; }

        public static TwitterSystemContext Create()
        {
            return new TwitterSystemContext();
        }
    }
}

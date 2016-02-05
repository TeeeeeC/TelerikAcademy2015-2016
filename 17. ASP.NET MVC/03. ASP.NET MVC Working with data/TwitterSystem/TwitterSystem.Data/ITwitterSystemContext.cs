namespace TwitterSystem.Data
{
    using Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface ITwitterSystemContext
    {
        int SaveChanges();

        void Dispose();

        IDbSet<User> Users { get; set; }

        IDbSet<Tweet> Tweets { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}

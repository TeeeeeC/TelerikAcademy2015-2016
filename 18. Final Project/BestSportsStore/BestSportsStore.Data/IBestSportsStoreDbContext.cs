namespace BestSportsStore.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Models;

    public interface IBestSportsStoreDbContext
    {
        int SaveChanges();

        void Dispose();

        IDbSet<Brand> Brands { get; }

        IDbSet<Category> Categories { get; }

        IDbSet<SubCategory> SubCategories { get; }

        IDbSet<Comment> Comments { get; }

        IDbSet<Like> Likes { get; }

        IDbSet<Product> Products { get; }

        IDbSet<Size> Sizes { get; }

        IDbSet<Sport> Sports { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}

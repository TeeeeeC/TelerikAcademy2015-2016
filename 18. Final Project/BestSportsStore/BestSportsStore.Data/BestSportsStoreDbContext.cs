namespace BestSportsStore.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    using Models;
    using Migrations;

    public class BestSportsStoreDbContext : IdentityDbContext<User>, IBestSportsStoreDbContext
    {
        public BestSportsStoreDbContext()
            : base("BestSportsStore")
        {
        }

        public virtual IDbSet<Brand> Brands { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<SubCategory> SubCategories { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public virtual IDbSet<Like> Likes { get; set; }

        public virtual IDbSet<Product> Products { get; set; }

        public virtual IDbSet<Size> Sizes { get; set; }

        public virtual IDbSet<Sport> Sports { get; set; }

        public static BestSportsStoreDbContext Create()
        {
            return new BestSportsStoreDbContext();
        }
    }
}

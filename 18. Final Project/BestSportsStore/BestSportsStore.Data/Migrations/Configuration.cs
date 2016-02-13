namespace BestSportsStore.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<BestSportsStoreDbContext>
    {
        private SeedData data;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.data = new SeedData();
        }

        protected override void Seed(BestSportsStoreDbContext context)
        {
            if (context.Likes.Any())
            {
                return;
            }

            this.data.Seed();
        }
    }
}

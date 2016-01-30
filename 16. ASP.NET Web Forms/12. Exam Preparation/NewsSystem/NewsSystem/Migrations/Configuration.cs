namespace NewsSystem.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Models.NewsSystemDbContext>
    {

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewsSystem.Models.NewsSystemDbContext context)
        {
            if(context.Articles.Any())
            {
                return;
            }

            var seed = new SeedData(new Models.User()
            {
                UserName = "Anonimous"
            });

            context.Users.Add(seed.Author);

            context.SaveChanges();

            seed.Categories.ForEach(x => context.Categories.Add(x));
            seed.Articles.ForEach(x => context.Articles.Add(x));
            context.SaveChanges();
        }
    }
}

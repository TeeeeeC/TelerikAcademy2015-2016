namespace MusicStore.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<MusicStoreDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MusicStoreDbContext context)
        {
            var db = new MusicStoreDbContext();
            var countries = new string[]
                {
                    "Bulgaria", "Brazil", "France", "Germany", "Spain", "Italy", "Austria"
                };

            for (int i = 0; i < countries.Length; i++)
            {
                db.Countries.AddOrUpdate(new Country { Name = countries[i] });
            }

            db.SaveChanges();
            db.Dispose();
        }
    }
}

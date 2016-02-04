namespace MoviesSystem.Web.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<MoviesSystem.Web.Models.MoviesSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MoviesSystemDbContext context)
        {
            if(context.Movies.Any())
            {
                return;
            }

            var movie1 = new Movie
            {
                Title = "Interstellar",
                Director = "Christopher Nolan",
                Year = 2014,
                LeadingMaleRole = "Matthew McConaughey",
                LeadingFemaleRole = "Anne Hathaway",
                AgeLeadingMaleRole = 47,
                AgeLeadingFemaleRole = 34,
                Studio = "DreamWorks",
                StudioAddress = "US"
            };

            var movie2 = new Movie
            {
                Title = "Kingsman: The Secret Service",
                Director = "Matthew Vaughn",
                Year = 2014,
                LeadingMaleRole = "Colin Firth",
                LeadingFemaleRole = "Sofia Boutella",
                AgeLeadingMaleRole = 56,
                AgeLeadingFemaleRole = 34,
                Studio = "Dream",
                StudioAddress = "UK"
            };

            var movie3 = new Movie
            {
                Title = "Guardians of the Galaxy",
                Director = "James Gunn",
                Year = 2014,
                LeadingMaleRole = "Chris Pratt",
                LeadingFemaleRole = "Zoe Saldana",
                AgeLeadingMaleRole = 37,
                AgeLeadingFemaleRole = 38,
                Studio = "Works",
                StudioAddress = "US"
            };

            context.Movies.Add(movie1);
            context.Movies.Add(movie2);
            context.Movies.Add(movie3);
            context.SaveChanges();
        }
    }
}

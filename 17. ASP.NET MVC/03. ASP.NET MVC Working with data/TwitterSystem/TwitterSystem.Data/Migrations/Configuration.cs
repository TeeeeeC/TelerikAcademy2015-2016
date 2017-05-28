namespace TwitterSystem.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<TwitterSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterSystemContext context)
        {
            if(context.Users.Any())
            {
                return;
            }

            context.Roles.Add(new IdentityRole { Name = "Administator" });

            var passwordHash = new PasswordHasher();
            var hash = passwordHash.HashPassword("admin");

            context.Users.Add(new User
            {
                UserName = "admin",
                FullName = "ADMIN",
                PasswordHash = hash,
                SecurityStamp = Guid.NewGuid().ToString()
            });

            var hash1 = passwordHash.HashPassword("123456");
            context.Users.Add(new User
            {
                UserName = "Tosho",
                FullName = "Tosho Petrov",
                PasswordHash = hash1,
                SecurityStamp = Guid.NewGuid().ToString()
            });

            context.SaveChanges();

            var role = context.Roles.FirstOrDefault(r => r.Name == "Administator");
            var admin = context.Users.FirstOrDefault(u => u.UserName == "admin");

            admin.Roles.Add(new IdentityUserRole { RoleId = role.Id });

            context.SaveChanges();

            var user = context.Users.FirstOrDefault(u => u.UserName == "Tosho");
            for (int i = 0; i < 3; i++)
            {
                var tweet = new Tweet()
                {
                    Text = "This is #fail tweet " + (i + 1),
                    TimeStamp = DateTime.Now.AddDays((-1) * i),
                    LikesCount = i,
                    User = user
                };

                context.Tweets.Add(tweet);
            }

            context.SaveChanges();
        }
    }
}

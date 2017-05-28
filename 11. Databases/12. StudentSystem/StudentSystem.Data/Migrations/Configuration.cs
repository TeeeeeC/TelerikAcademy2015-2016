namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystem.Data.StudentDbContext";
        }

        protected override void Seed(StudentDbContext context)
        {
            context.Students.AddOrUpdate(s => s.Name,
                new Student
                {
                    Name = "Gosho",
                    Number = "12"
                });

            context.Courses.AddOrUpdate(c => c.Name,
                new Course
                {
                    Name = "C# part 2",
                });

            context.Homeworks.AddOrUpdate(h => h.Content,
                new Homework
                {
                    Content = "C# part 2",
                    TimeSent = DateTime.Now,
                });
        }
    }
}

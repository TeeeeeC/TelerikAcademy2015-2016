namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Data;
    using Data.Migrations;
    using Models;

    internal class Startup
    {
        static void Main()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentDbContext, Configuration>());

            var db = new StudentDbContext();
            var student = db.Students.Where(s => s.Id == 1).FirstOrDefault();
            var course = db.Courses.Where(c => c.Id == 1).FirstOrDefault();
            student.Courses.Add(course);
            course.Students.Add(student);
            db.SaveChanges(); 
        }
    }
}

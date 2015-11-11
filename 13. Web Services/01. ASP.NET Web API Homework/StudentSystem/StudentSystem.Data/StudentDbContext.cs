namespace StudentSystem.Data
{
    using System;
    using System.Data.Entity;

    using StudentSystem.Models;

    public class StudentDbContext : DbContext, IStudentDbContext
    {
        public StudentDbContext()
            : base("StudentDatabase")
        { 
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}

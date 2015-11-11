namespace StudentSystem.Data
{
    using Repositories;
    using Models;

    public interface IStudentsData
    {
        IRepository<Course> Courses { get; }

        IRepository<Homework> Homeworks { get; }

        IRepository<Student> Students { get; }

        void SaveChanges();
    }
}

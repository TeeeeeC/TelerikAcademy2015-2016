namespace StudentSystem.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class CourseRequestModel
    {
        public static Expression<Func<Course, CourseRequestModel>> FromCourse
        {
            get
            {
                return c => new CourseRequestModel
                {
                    Id = c.Id,
                    Name = c.Name
                };
            }
        }

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public ICollection<LectureRequestModel> Lectures { get; set; }

        public ICollection<StudentRequestModel> Students { get; set; }

        public ICollection<HomeworkRequestModel> Homeworks { get; set; }
    }
}
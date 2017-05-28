namespace StudentSystem.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class StudentRequestModel
    {
        public static Expression<Func<Student, StudentRequestModel>> FromStudent
        {
            get
            {
                return s => new StudentRequestModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Number = s.Number
                };
            }
        }

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }

        public ICollection<CourseRequestModel> Courses { get; set; }

        public ICollection<HomeworkRequestModel> Homeworks { get; set; }
    }
}
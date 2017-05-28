namespace StudentSystem.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class HomeworkRequestModel
    {
        public static Expression<Func<Homework, HomeworkRequestModel>> FromHomework
        {
            get
            {
                return h => new HomeworkRequestModel
                {
                    Content = h.Content,
                    TimeSent = h.TimeSent
                };
            }
        }

        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime TimeSent { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }
    }
}
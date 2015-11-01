namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }

        public virtual ICollection<Course> Courses 
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}

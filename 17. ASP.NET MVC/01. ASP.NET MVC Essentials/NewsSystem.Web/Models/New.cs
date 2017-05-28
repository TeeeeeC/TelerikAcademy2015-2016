namespace NewsSystem.Web.Models
{
    using System;

    public class New
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int Rating { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Creator { get; set; }

        public string Category { get; set; }
    }
}
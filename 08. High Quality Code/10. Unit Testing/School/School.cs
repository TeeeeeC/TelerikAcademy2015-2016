using System;
using System.Collections.Generic;

namespace School
{
    public class School
    {
        private ICollection<Course> courses = new List<Course>();

        public ICollection<Course> Courses 
        { 
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (!this.courses.Contains(course))
            {
                throw new ArgumentException("This course doesn't exist!");
            }

            this.courses.Remove(course);
        }
    }
}

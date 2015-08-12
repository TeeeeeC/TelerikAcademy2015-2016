using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private const int MAX_NUMBER_OF_STUDENTS = 30;

        private ICollection<Student> students;

        public Course()
        {
            this.Students = new List<Student>();
        }

        public Course(ICollection<Student> students)
        {
            this.Students = students;
        }

        public ICollection<Student> Students 
        { 
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count >= MAX_NUMBER_OF_STUDENTS) 
                {
                    throw new ArgumentOutOfRangeException(string.Format("The number of students in course must be less than {0}!", MAX_NUMBER_OF_STUDENTS));
                }

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.Students.Count >= MAX_NUMBER_OF_STUDENTS)
            {
                throw new ArgumentOutOfRangeException(string.Format("The number of students in course must be less than {0}!", MAX_NUMBER_OF_STUDENTS));
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!this.Students.Contains(student))
            {
                throw new ArgumentException("There is no such student!");
            }

            this.Students.Remove(student);
        }
    }
}

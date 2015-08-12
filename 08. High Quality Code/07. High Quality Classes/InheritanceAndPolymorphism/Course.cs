namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("The name must not be empty string!");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("The teacherName must not be empty string!");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students 
        {
            get
            {
                return this.students;
            }

            set
            {
                foreach (string student in value)
                {
                    if (student.Length == 0)
                    {
                        throw new ArgumentOutOfRangeException("The student must not be empty string!");
                    }
                }

                this.students = value;
            }
        }

        protected virtual string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}

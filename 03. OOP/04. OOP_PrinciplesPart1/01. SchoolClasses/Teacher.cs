namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, IComments
    {
        private ICollection<Discipline> disciplines = new HashSet<Discipline>();
        private ICollection<string> comments = new List<string>();

        public Teacher(string name) : base(name)
        {
        }

        public ICollection<Discipline> AllDisciplines 
        { 
            get
            {
                return this.disciplines;
            }
        }

        public ICollection<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public void RemoveComment(string comment)
        {
            this.comments.Remove(comment);
        }
    }
}

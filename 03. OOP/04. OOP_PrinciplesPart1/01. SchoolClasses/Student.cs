namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Student : People, IComments
    {
        private string uniqueClassNumber;
        private ICollection<string> comments = new List<string>();

        public Student(string name, string uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            private set
            {
                if (value.Length != 6)
                {
                    throw new ArgumentOutOfRangeException("Class number must be equal to 6 symbols!");
                }
                this.uniqueClassNumber = value;
            }
        }

        public ICollection<string> Comments 
        { 
            get
            {
                return this.comments;
            }
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

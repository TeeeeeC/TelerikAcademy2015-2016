namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComments
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private ICollection<string> comments = new List<string>();

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length < 1)
                {
                    throw new ArgumentNullException("Discipline must have a name!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures 
        { 
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures must be bigger than 0!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises 
        { 
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises must be positive!");
                }
                this.numberOfExercises = value;
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

namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComments
    {
        private HashSet<People> people = new HashSet<People>();
        private ICollection<string> comments = new List<string>();

        public Class(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public HashSet<People> People 
        { 
            get
            {
                return this.people;
            }
        }

        public ICollection<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public void AddPeople(People newPerson)
        {
            foreach (var person in this.people)
            {
                if(newPerson is Student && person is Student)
                {
                    var newStudent = newPerson as Student;
                    var student = person as Student;
                    if(student.UniqueClassNumber == newStudent.UniqueClassNumber)
                    {
                        throw new ArgumentException("Class numbers of students must be UNIQUE!");
                    }
                }
            }
            this.people.Add(newPerson);
        }

        public void RemovePeople(People oldPerson)
        {
            this.people.Remove(oldPerson);
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

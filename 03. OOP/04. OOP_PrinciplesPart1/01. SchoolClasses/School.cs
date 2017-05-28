namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private ICollection<Class> classes = new HashSet<Class>();

        public ICollection<Class> Classes 
        { 
            get
            {
                return this.classes;
            }
        }

        public void AddClass(Class newClass)
        {
            foreach (var someClass in classes)
            {
                if(newClass == someClass)
                {
                    throw new ArgumentException("The class name must be UNIQUE!");
                }
            }
            this.classes.Add(newClass);
        }

        public void RemoveClass(Class oldClass)
        {
            this.classes.Remove(oldClass);
        }
    }
}

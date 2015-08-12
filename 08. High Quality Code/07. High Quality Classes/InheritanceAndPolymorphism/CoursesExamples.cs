namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main(string[] args)
        {
            var students = new List<string>() { "Peter", "Maria", "Milena", "Todor"};
            var localCourse = new LocalCourse("Databases", "Svetlin Nakov", students, "Enterprise");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", "Mario Peshev",
                new List<string>() { "Thomas", "Ani", "Steve" }, "Sofia");
            Console.WriteLine(offsiteCourse);
        }
    }
}

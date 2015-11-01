namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClassesMain
    {
        public static void Main()
        {
            var school = new School();
            var newClass = new Class("3");
            school.AddClass(newClass);
            Console.WriteLine(newClass.Name);

            var someStudent = new Student("Pesho", "252525");
            var anotherStudent = new Student("Gosho", "252526");
            newClass.AddPeople(someStudent);
            newClass.AddPeople(anotherStudent);

            var someTeacher = new Teacher("Cura");
            newClass.AddPeople(someTeacher);

            var discipline = new Discipline("Mathematics", 10, 20);
            someTeacher.AddDiscipline(discipline);
            Console.WriteLine(discipline.Name);
            foreach (var person in newClass.People)
            {
                Console.WriteLine(person.Name);
            }

            someStudent.AddComment("Will you have a lecture tomorrow?");
            anotherStudent.AddComment("No, The teacher is ill!");

            Console.WriteLine("Student: {0}\nUnique Number: {1}", someStudent.Name, someStudent.UniqueClassNumber);
            foreach (var comment in someStudent.Comments)
            {
                Console.WriteLine("Comments: {0}", comment);
            }
            someStudent.RemoveComment("Will you have a lecture tomorrow?");
        }
    }
}

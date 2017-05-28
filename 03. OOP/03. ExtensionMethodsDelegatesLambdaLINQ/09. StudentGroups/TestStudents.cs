namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ExtensionMethods;

    public class TestStudents
    {
        public static void Main()
        {
            // Input
            var students = new List<Student>();

            students.Add(new Student("Pesho", "Todorov", "111106", "02 1234567", "ptodorov@abv.bg", 
                new List<int>() { 5, 2, 3, 4}, 5));
            students.Add(new Student("Ivan", "Grozdanov", "111007", "03134 1234", "itodorov@gmail.com",
                new List<int>() { 2, 2, 3, 6 }, 2));
            students.Add(new Student("Gosho", "Ivanov", "110508", "03134 1434", "gtodorov@gmail.bg",
                new List<int>() { 5, 6, 6, 6 }, 5));
            students.Add(new Student("Toshkata", "Iliev", "111006", "02 1236667", "ttodorov@abv.bg",
                new List<int>() { 2, 2, 2, 2 }, 1));

            // Problem 9. Student groups
            var studentsInGroup2Linq =
                from student in students
                where student.GroupNumber == 2
                orderby student.Firstname
                select student;

            foreach (var student in studentsInGroup2Linq)
            {
                Console.WriteLine("{0} from group {1} - Linq", student.Firstname, student.GroupNumber);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 10. Student groups extensions
            var studentsInGroup2ExtMethod = students.SelectInGroup2();
            studentsInGroup2ExtMethod.SortByFirstName();

            foreach (var student in studentsInGroup2ExtMethod)
            {
                Console.WriteLine("{0} from group {1} - Extension Methods", student, students.FindGroupNumber(2));
            }

            Console.WriteLine(new string('-', 20));

            // Problem 11. Extract students by email
            var studentsByEmail =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (var student in studentsByEmail)
            {
                Console.WriteLine("{0} {1} {2}", student.Firstname, student.Lastname, student.Email);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 12. Extract students by phone
            var studentsByPhoneNumber =
                from student in students
                where student.Tel.Substring(0, 2) == "02"
                select student;

            foreach (var student in studentsByEmail)
            {
                Console.WriteLine("{0} {1} {2}", student.Firstname, student.Lastname, student.Tel);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 13. Extract students by marks
            var studentsByMarks =
                from student in students
                where student.Marks.Contains(6)
                select student;

            foreach (var student in studentsByMarks)
            {
                var someClass = new { FullName = student.Firstname + " " + student.Lastname, Marks = student.Marks };
                Console.WriteLine("{0} {1}", someClass.FullName, someClass.Marks.Find(x => x == 6));
            }

            Console.WriteLine(new string('-', 20));

            // Problem 14. Extract students with two marks
            var studentsWithTwoMarks = students.FindStudentsWithTwoMarks2();

            foreach (var student in studentsWithTwoMarks)
            {
                Console.WriteLine("{0}", student);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 15. Extract marks
            var extractMarksIn2006 =
                from student in students
                where student.FN.Substring(4, 2) == "06"
                select student;

            foreach (var student in extractMarksIn2006)
            {
                Console.Write("{0} {1} - Marks: ", student.Firstname, student.Lastname);
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0}, ", mark);
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 20));

            // Problem 17. Longest string
            var arrOfStrings = new string[]{ "Pesho", "Gosho", "Toshkata", "Haralampi", "Asq"};

            var maxLen =
                (from str in arrOfStrings
                select str.Length).Max();

            var strWithMaxLen =
                from str in arrOfStrings
                where str.Length == (int)maxLen
                select str;

            foreach (var item in strWithMaxLen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 18. Grouped by GroupNumber
            var studentsInGroupLinq =
                from student in students
                group student by student.GroupNumber;


            foreach (var studentsOfGroup in studentsInGroupLinq)
            {
                Console.WriteLine("Group = {0}          Linq", studentsOfGroup.Key);
                foreach (var group in studentsOfGroup)
                {
                    Console.WriteLine("{0} {1} - {2}", group.Firstname, group.Lastname, group.GroupNumber);
                }
            }

            Console.WriteLine(new string('-', 20));

            // Problem 19. Grouped by GroupName extensions
            var studentsInGroupExtMethod = students.GroupedByGroupName();

            foreach (var student in studentsInGroupExtMethod)
            {
                Console.WriteLine(student);
            }
        }
    }
}

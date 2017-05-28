namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LinqTasks
    {
        static void Main()
        {
            //Problem 3 First before last
            var arr3Task = new [] 
            { 
                new {Firstname = "Pesho" , Lastname = "Ivanov"},
                new {Firstname = "Gosho" , Lastname = "Petrov"},
                new {Firstname = "Ivan" , Lastname = "Todorov"},
            };

            var foundStudents =
                from name in arr3Task
                where name.Firstname.CompareTo(name.Lastname) == -1
                select name;

            foreach (var student in foundStudents)
            {
                Console.WriteLine("{0} {1}", student.Firstname, student.Lastname);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 4 Age range
            var arr4Task = new[]
            {
                new {Firstname = "Pesho" , Lastname = "Ivanov", Age = 20},
                new {Firstname = "Gosho" , Lastname = "Petrov", Age = 25},
                new {Firstname = "Ivan" , Lastname = "Todorov", Age = 21},
                new {Firstname = "Todor" , Lastname = "Batkov", Age = 19},
            };

            var foundStudentsInRangeAge =
                from data in arr4Task
                where data.Age > 18 && data.Age < 24
                select data;

            foreach (var student in foundStudentsInRangeAge)
            {
                Console.WriteLine("{0} {1} {2}", student.Firstname, student.Lastname, student.Age);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 5 Order students
            var arr5Task = new[]
            {
                new {Firstname = "Pesho" , Lastname = "Ivanov"},
                new {Firstname = "Ivan" , Lastname = "Petrov"},
                new {Firstname = "Ivan" , Lastname = "Todorov"},
                new {Firstname = "Todor" , Lastname = "Batkov"},
            };

            var sortedByFirstNameLambda = arr5Task.OrderByDescending(x => x.Firstname).ThenByDescending(y => y.Lastname);

            foreach (var student in sortedByFirstNameLambda)
            {
                Console.WriteLine("{0} {1} - Lambda", student.Firstname, student.Lastname);
            }

            var sortedByFirstNameLinq =
                from data in arr5Task
                orderby data.Firstname descending, 
                data.Lastname descending
                select data;

            foreach (var student in sortedByFirstNameLinq)
            {
                Console.WriteLine("{0} {1} - Linq", student.Firstname, student.Lastname);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 6 Order students
            int[] arr6Task = new[] { 5, 6, 42, 9, 21, 54 };

            var numsDivBy5and7Lambda = arr6Task.Where(x => x %3 == 0 && x %7 == 0);

            foreach (var number in numsDivBy5and7Lambda)
            {
                Console.WriteLine("{0} - Lambda", number);
            }

            var numsDivBy5and7Linq =
                from number in arr6Task
                where number % 3 == 0 && number % 7 == 0
                select number;

            foreach (var number in numsDivBy5and7Linq)
            {
                Console.WriteLine("{0} - Linq", number);
            }
        }
    }
}

namespace _02.StudentsAnaWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method)
            var firstNames = new string[] { "Pesho", "Gosho", "Ivan", "Tosho", "Goran", "Tulumbata", "Shumbata", "Bucata", "Pecata", "Ana" };
            var lastNames = new string[] { "Ivanov", "Todorov", "Nikolov", "Minchev", "Milushev", "Stoqnov", "Vargala", "Vasilev", "Alexandrov", "Pironkova" };
            var listOfStudents = new List<Student>();
            var rand = new Random();
            for (int i = 9; i >= 0; i--)
            {
                listOfStudents.Add(new Student(firstNames[i], lastNames[i], rand.Next(1, 10)));
            }

            var sortedStudentsByGrade = listOfStudents.OrderBy(x => x.Grade);
            foreach (var item in sortedStudentsByGrade)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var listOfWorkers = new List<Worker>();
            for (int i = 0; i < 10; i++)
            {
                listOfWorkers.Add(new Worker(firstNames[i], lastNames[i], rand.Next(1000, 10001), (int)Worker.MoneyPerHour(rand.Next(8, 41))));
            }

            var sortedWorkerByMoneyPerHour = listOfWorkers.OrderByDescending(x => x.WorkHoursPerDay);
            foreach (var item in sortedWorkerByMoneyPerHour)
            {
                Console.WriteLine(item + " " + item.WorkHoursPerDay + " BGN");
            }

            //Merge the lists and sort them by first name and last name.
            var mergeHumans = new List<Human>();
            foreach (var student in sortedStudentsByGrade)
            {
                mergeHumans.Add(student);
            }

            foreach (var worker in sortedWorkerByMoneyPerHour)
            {
                mergeHumans.Add(worker);
            }

            Console.WriteLine();
            var sortedHumans = mergeHumans.OrderBy(x => x.FirstName).ThenBy(y => y.LastName);
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human.FirstName + " "+ human.LastName);
            }
        }
    }
}

namespace _01.StudentClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            secondStudent.Course = 5;
            secondStudent.FistName = "Pesho";
            secondStudent.SSN = 6;
            Console.WriteLine(firstStudent == secondStudent);
            Console.WriteLine(firstStudent.Equals(secondStudent));

            Student someStudent = (Student)secondStudent.Clone();
            someStudent.FistName = "Gosho";
            someStudent.SSN = 7;
            Console.WriteLine(secondStudent.FistName);
            Console.WriteLine(someStudent.FistName);
            Console.WriteLine(secondStudent.CompareTo(someStudent));
        }
    }
}

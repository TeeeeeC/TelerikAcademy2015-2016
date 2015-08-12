using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class CourseTest
    {
        private const int MAX_NUMBER_OF_STUDENTS = 30;

        [TestMethod]
        public void AddingNewStudentShouldProperlyWork()
        {
            var course = new Course();
            course.AddStudent(new Student("Pesho", 10001));

            Assert.AreEqual(1, course.Students.Count, string.Format("The students in course must be less than {0}!", MAX_NUMBER_OF_STUDENTS));
        }

        [TestMethod]
        public void AddingNewStudentWithConstructorShouldProperlyWork()
        {
            var course = new Course(new List<Student>() { new Student("Pesho", 10001) });

            Assert.AreEqual(1, course.Students.Count, string.Format("The students in course must be less than {0}!", MAX_NUMBER_OF_STUDENTS));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingStudentsBiggerThan29ShoudThrow()
        {
            var course = new Course();

            for (int i = 0; i <= MAX_NUMBER_OF_STUDENTS; i++)
            {
                course.AddStudent(new Student("Pesho", 10001 + i));
            }
        }

        [TestMethod]
        public void RemovingStudentShouldProperlyWork()
        {
            var course = new Course();
            var student = new Student("Pesho", 10001);
            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.Students.Count, string.Format("The students in course must be less than {0}!", MAX_NUMBER_OF_STUDENTS));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingStudentWhoDoesNotExistShoudThrow()
        {
            var course = new Course();
            var student = new Student("Pesho", 10001);
            var student1 = new Student("Tosho", 10031);
            course.AddStudent(student);
            course.RemoveStudent(student1);
        }
    }
}

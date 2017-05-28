using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void CreatingNewStudentShouldProperlySetNameAndUniqueNumber()
        {
            var student = new Student("Pesho", 10001);

            Assert.AreEqual("Pesho", student.Name, string.Format("The student name is incorrect!"));
            Assert.AreEqual(10001, student.UniqueNumber, string.Format("The student name is incorrect!"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingNewStudentShouldThrowBecauseOfIncorrectUniqueNumber()
        {
            var student = new Student("Pesho", 99);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingNewStudentShouldThrowBecauseOfEmptyName()
        {
            var student = new Student(string.Empty, 10001);
        }
    }
}

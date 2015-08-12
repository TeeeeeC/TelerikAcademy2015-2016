using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void AddingNewCourseShoudProperlyWork()
        {
            var school = new School();
            school.AddCourse(new Course());

            Assert.AreEqual(1, school.Courses.Count);
        }

        [TestMethod]
        public void RemovingExistingCourseShoudProperlyWork()
        {
            var school = new School();
            var course = new Course();
            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.AreEqual(0, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingNonExistingCourseShoudThrow()
        {
            var school = new School();
            var course = new Course();
            var course1 = new Course();
            school.AddCourse(course);
            school.RemoveCourse(course1);
        }
    }
}

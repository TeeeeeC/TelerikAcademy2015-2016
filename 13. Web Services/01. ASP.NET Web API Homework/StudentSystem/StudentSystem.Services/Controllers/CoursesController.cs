namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using StudentSystem.Models;
    using Models;

    public class CoursesController : ApiController
    {
        private IStudentsData data;

        public CoursesController()
            : this(new StudentsData())
        {
        }

        public CoursesController(IStudentsData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var courses = this.data
                .Courses
                .All()
                .Select(CourseRequestModel.FromCourse);

            return Ok(courses);
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbCourse = this.data
                .Students
                .All()
                .FirstOrDefault(s => s.Id == id);
            if (dbCourse == null)
            {
                return BadRequest("Such course does not exist in database!");
            }

            var course = new CourseRequestModel
            {
                Name = dbCourse.Name
            };

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Create(CourseRequestModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCourse = new Course
            {
                Name = course.Name
            };

            this.data.Courses.Add(newCourse);
            this.data.SaveChanges();

            course.Id = newCourse.Id;

            return Ok(course);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, CourseRequestModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbCourse = this.data
                .Students.All()
                .FirstOrDefault(s => s.Id == id);
            if (dbCourse == null)
            {
                return BadRequest("Such course does not exist in database!");
            }

            dbCourse.Name = course.Name;
            this.data.SaveChanges();

            course.Id = id;
            return Ok(course);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbCourse = this.data
                .Courses
                .All()
                .FirstOrDefault(c => c.Id == id);
            if (dbCourse == null)
            {
                return BadRequest("Such course does not exist in database!");
            }

            this.data.Courses.Delete(dbCourse);
            this.data.SaveChanges();

            return Ok(id);
        }
    }
}

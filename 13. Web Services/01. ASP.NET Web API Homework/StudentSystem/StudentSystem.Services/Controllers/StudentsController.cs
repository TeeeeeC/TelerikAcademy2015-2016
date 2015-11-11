namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using StudentSystem.Models;
    using Models;

    public class StudentsController : ApiController
    {
        private IStudentsData data;

        public StudentsController()
            : this(new StudentsData())
        {
        }

        public StudentsController(IStudentsData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var students = this.data
                .Students
                .All()
                .Select(StudentRequestModel.FromStudent);

            return Ok(students);
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbStudent = this.data
                .Students
                .All()
                .FirstOrDefault(s => s.Id == id);
            if (dbStudent == null)
            {
                return BadRequest("Such student does not exist in database!");
            }

            var student = new StudentRequestModel
            {
                Id = dbStudent.Id,
                Name = dbStudent.Name,
                Number = dbStudent.Number
            };

            return Ok(student);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentRequestModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newStudent = new Student
            {
                Name = student.Name,
                Number = student.Number,
            };

            this.data.Students.Add(newStudent);
            this.data.SaveChanges();

            student.Id = newStudent.Id;

            return Ok(student);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, StudentRequestModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbStudent = this.data
                .Students.All()
                .FirstOrDefault(s => s.Id == id);
            if (dbStudent == null)
            {
                return BadRequest("Such student does not exist in database!");
            }

            dbStudent.Name = student.Name;
            dbStudent.Number = student.Number;
            this.data.SaveChanges();

            student.Id = id;
            return Ok(student);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbStudent = this.data
                .Students
                .All()
                .FirstOrDefault(s => s.Id == id);
            if (dbStudent == null)
            {
                return BadRequest("Such student does not exist in database!");
            }

            this.data.Students.Delete(dbStudent);
            this.data.SaveChanges();

            return Ok(id);
        }
    }
}
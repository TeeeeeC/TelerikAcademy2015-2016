namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using StudentSystem.Models;
    using Models;

    public class HomeworksController : ApiController
    {
        private IStudentsData data;

        public HomeworksController()
            : this(new StudentsData())
        {
        }

        public HomeworksController(IStudentsData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var homeworks = this.data
                .Homeworks
                .All()
                .Select(HomeworkRequestModel.FromHomework);

            return Ok(homeworks);
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbHomework = this.data
                .Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);
            if (dbHomework == null)
            {
                return BadRequest("Such homework does not exist in database!");
            }

            var homework = new HomeworkRequestModel
            {
                Content = dbHomework.Content,
                TimeSent = dbHomework.TimeSent
            };

            return Ok(homework);
        }

        [HttpPost]
        public IHttpActionResult Create(HomeworkRequestModel homework)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbCourseId = this.data
                .Courses
                .All()
                .Where(c => c.Id == homework.CourseId)
                .Select(cour => cour.Id)
                .FirstOrDefault();
            if (dbCourseId == 0)
            {
                return BadRequest("Such course ID does not exist!");
            }

            var dbStudentId = this.data
                .Students
                .All()
                .Where(s => s.Id == homework.StudentId)
                .Select(st => st.Id)
                .FirstOrDefault();
            if (dbStudentId == 0)
            {
                return BadRequest("Such student ID does not exist!");
            }

            var newHomework = new Homework
            {
                Content = homework.Content,
                TimeSent = homework.TimeSent,
                CourseId = dbCourseId,
                StudentId = dbStudentId
            };

            this.data.Homeworks.Add(newHomework);
            this.data.SaveChanges();

            homework.Id = newHomework.Id;

            return Ok(homework);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, HomeworkRequestModel homework)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbHomework = this.data
                .Homeworks.All()
                .FirstOrDefault(h => h.Id == id);
            if (dbHomework == null)
            {
                return BadRequest("Such homework does not exist in database!");
            }

            dbHomework.Content = homework.Content;
            dbHomework.TimeSent = homework.TimeSent;
            this.data.SaveChanges();

            homework.Id = id;
            return Ok(homework);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbHomework = this.data
                .Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);
            if (dbHomework == null)
            {
                return BadRequest("Such homework does not exist in database!");
            }

            this.data.Homeworks.Delete(dbHomework);
            this.data.SaveChanges();

            return Ok(id);
        }
    }
}

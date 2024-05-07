using Day01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly TrainingSystemContext context;

        public CoursesController(TrainingSystemContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var courses = context.Courses.ToList();

            if (courses == null)
                return NotFound();

            return Ok(courses);
        }

        [HttpDelete("{id}")]
        public ActionResult deleteCourse(int id)
        {
            Course cr = context.Courses.Find(id);
            
            if (cr == null) 
                return NotFound();

            context.Entry(cr).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();

            var courses = context.Courses.ToList();

            return Ok(courses);
        }

        [HttpPut("{id}")]
        public ActionResult put(Course course,int id)
        {
            if(id != course.Id)
                return BadRequest();

            Course cr = context.Courses.FirstOrDefault(cr => cr.Id == id);
            if(cr == null)
                return NotFound();

            context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //context.Courses.Update(course);
            context.SaveChanges();

            Course crUpdated = context.Courses.Find(id);
            return Ok(crUpdated);
        }

        [HttpPost]
        public ActionResult post(Course course)
        {
            if(course == null)
                return BadRequest();

            context.Courses.Add(course);
            context.SaveChanges();

            return Ok(course);
        }

        [HttpGet("{id}")]
        public ActionResult getCourseById(int id)
        {
            Course cr = context.Courses.Find(id);
            if(cr == null)
                return NotFound();

            return Ok(cr);
        }

        [HttpGet("/api/CourseName/{name:alpha}")]
        public ActionResult getCourseByName(string name)
        {
            Course cr = context.Courses.SingleOrDefault(cr=> cr.Name == name);
            if (cr == null)
                return NotFound();

            return Ok(cr);
        }
    }
}

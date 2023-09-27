using WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        CourseDbContext db = new CourseDbContext();

        [HttpGet]
        public IEnumerable<Course> Index()
        {
            return db.Courses;
        }
        [HttpPost]
        public IActionResult PostBooks(Course c)
        {
            db.Courses.Add(c);
            db.SaveChanges();
            return Ok("Courses added successfully");
        }
    }
}

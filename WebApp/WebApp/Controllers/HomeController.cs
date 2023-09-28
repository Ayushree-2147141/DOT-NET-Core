using WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModel;
using System.Linq;

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
        public IActionResult AddCourse(Course c)
        {
            db.Courses.Add(c);
            db.SaveChanges();
            return Ok("Courses added successfully");
        }


        [HttpPut]
        public IActionResult PutCourse(Course c)
        {
            db.Courses.Update(c);
            db.SaveChanges();
            return Ok("course updated");
        }

        [HttpDelete]
        public IActionResult DeleteCourse(int id)
        {
            var course = db.Courses.Where(x => x.Id == id).FirstOrDefault();
            db.Courses.Remove(course);
            db.SaveChanges();
            return Ok("course deleted");
        }

        [HttpGet]
        [Route("/get-student-data")]
        public IEnumerable<StudentData> GetStudentData()
        {
            var data = db.StudentTables.
               Join(db.Courses,
               s => s.CourseId, c => c.Id, (s, c) =>
               new { Id = s.StudentId, Name = s.StudentName, CourseName = c.CourseName, CourseId = c.Id });

            var books = data.Join(db.CourseBookMappings, d => d.CourseId, cb => cb.CourseId
            , (d, cb) => new { d, cb }).Join(db.Books, cbm => cbm.cb.BookId, b => b.BookId,

            (cbm, b) => new { BookId = b.BookId, BookName = b.BookName, StudentId = cbm.d.Id });

            List<StudentData> studentdatalist = new List<StudentData>();

            foreach (var item in data)
            {
                StudentData student = new StudentData();
                student.Id = item.Id;
                student.CourseName = item.CourseName;
                student.Name = item.Name;
                List<StudentBooks> studentbooks = new List<StudentBooks>();
                var bookdata = books.Where(x => x.StudentId == item.Id);
                foreach (var book in bookdata)
                {
                    StudentBooks s = new StudentBooks();
                    s.Id = book.BookId;
                    s.BookName = book.BookName;
                    studentbooks.Add(s);

                }
                student.studentBooks = studentbooks;
                studentdatalist.Add(student);
            }

            return studentdatalist;
        

    }

        [HttpGet]
        [Route("/test")]
        public IList<Book> LinqPractice()
        {
            //var data = db.Books.Take(1).ToList()
            //skip data
            //var temp = db.Books.Skip(1).ToList();
            //var skippedData = db.Books.Skip(1).ToList();
            //IQueryable query = db.Books.Skip(1);    
            //return data;
            //return skippedData;
            //var data = db.Books.Take(1).ToList();
            var orderbyValueDesc = db.Books.OrderByDescending(x => x.BookId).ToList();
            var orderbyValueAsc = db.Books.OrderBy(x => x.BookId);

            //var single = db.Books.SingleOrDefault

            List <int> numbers1 = new List<int> { 1 }; //can use single when sure we have one item
            List <int> numbers2 = new List<int> (); //can use singleOrDefault when we are not sure about the number of items in LIST

            var single = numbers1.Single();
            //var single = numbers2.SingleOrDefault();    
            return orderbyValueDesc;
        }
    }

   
}

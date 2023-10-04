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
            var data = db.Books.Take(1).ToList();
            var orderbyValueDesc = db.Books.OrderByDescending(x => x.BookId).ToList();

            //descending using two 
            var descdata = db.Books.OrderByDescending(x => x.BookId).ThenBy(x => x.BookName).ToList();

            var orderbyValueAsc = db.Books.OrderBy(x => x.BookId);

            //var single = db.Books.SingleOrDefault

            List<int> numbers1 = new List<int> { 1 }; //can use single when sure we have one item
            List<int> numbers2 = new List<int>(); //can use singleOrDefault when we are not sure about the number of items in LIST

            //var single = numbers1.Single();
            //var single = numbers2.SingleOrDefault();
            //
            //var first = numbers2.First(); cannot use this
            var first = numbers1.First();
            var firstorlast = numbers2.FirstOrDefault();

            var last = numbers1.Last();
            var lastordefault = numbers2.LastOrDefault();


            //SELECT
            var selectedData = db.Books.Select(x => x.BookId);

            var demoCollection = new List<int>() { 1, 1, 2, 3, 4, 5, 6 };
            var demoCollection2 = new List<int>() { 1, 3, 6 , 10, 12};
            var sum = demoCollection.Sum();

            var distinctValues = demoCollection.Distinct();

            var evenSum = demoCollection.Sum(x => { if (x % 2 == 0) { return x; } else { return 0; } });

            //average
            var avg = demoCollection.Average();
            var max = demoCollection.Max(); 
            var min = demoCollection.Min(); 
            var count = demoCollection.Count();


            var groupByCollection = demoCollection.GroupBy(x => x);
            var bookdata = db.Books;
            var bookCount = bookdata.GroupBy(x => x.BookName).Count();


            //foreach (var line in data.GroupBy(info => info.BookName)
            //            .Select(group => new {
            //                BookName = group.Key,
            //                BookCount = group.Count()
            //            })
            //            .OrderBy(x => x.BookName))
            //{ 
            //    Console.WriteLine(line);
            //}

            var intersect = demoCollection.Intersect(demoCollection2);

            //var bookCount = demoCollection.GroupBy(x => );
            //max
            //min
            //count

            return data;
        }

        [HttpPost]
        [Route("/validate")]
        public IActionResult SomeApi(SampleRequest samplereq)
        {
            if(ModelState.IsValid)
            {
                return Ok("validated values");
            }
            else
            {
                return Ok("invalid");
            }
        }
    }

   
}

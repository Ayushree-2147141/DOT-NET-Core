using Microsoft.AspNetCore.Mvc;
using DemoWebApp.Models;
using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Books> booklist = new List<Books>();

            //HttpClient client = new HttpClient();

            //dispose the object when not in use
            using(HttpClient client = new HttpClient())
            {
                // type of request
                // api
                // type of response

                var data = client.GetAsync("https://localhost:7267/api/Home").Result.Content.ReadAsStringAsync().Result;
                booklist = JsonConvert.DeserializeObject<IEnumerable<Books>>(data);
            }
            //types of data 
            ViewBag.Message = "Ayushree";
            ViewData["Msg"] = "I am from ViewData";
            TempData["Msg"] = "From TempData";


            return View(booklist);
        }
    }
}

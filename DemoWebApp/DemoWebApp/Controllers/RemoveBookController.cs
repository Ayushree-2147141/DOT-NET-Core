using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace DemoWebApp.Controllers
{
    public class RemoveBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RemoveBook(Books books)
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new StringContent(JsonConvert.SerializeObject(books), System.Text.Encoding.UTF8, "application/json");
                var data = client.DeleteAsync("https://localhost:7267/api/Home").Result.Content.
                     ReadAsStringAsync().Result;

            }
            return RedirectToAction("Index", "Home");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SessionData.Models;
using System.Diagnostics;

namespace SessionData.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "User1");
            HttpContext.Session.SetInt32("Age", 20);
            return View();
        }
        public ActionResult Get()
        {
            User user = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = HttpContext.Session.GetInt32("Age").Value
            };
            return View(user);
        }

        public ActionResult GetQueryString(string name,int age)
        {
            User user = new User()
            {
                Name = name,
                Age = age
            };
            return View(user);
          
        }
       
    }
}
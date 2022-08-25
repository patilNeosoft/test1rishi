using Cookies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            //set key value in cookie
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("Name", $"{user.Name}", option);

            return RedirectToAction("Dashboard");
        }
        public ActionResult Dashboard()
        {
           ViewBag.name = Request.Cookies["name"];
            return View();
        }

        //delete
        public ActionResult Remove()
        {
            Response.Cookies.Delete("Name");
            return View("Index");
        }


    }
}
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppUser.Models;

namespace WebAppUser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["data1"] = "Data comes from controller data using viewdata";
            ViewBag.data2 = "data from view bag";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

    }


}

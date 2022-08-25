using Burger_With_Database_MVC.Models;
using Burger_With_Database_MVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace Burger_With_Database_MVC.Controllers
{
    public class AdminController : Controller
    {
       

        readonly IAdminS _adminS;
        public AdminController(IAdminS adminS)
        {
            _adminS = adminS;
        }

        //display page to take input
        [HttpGet]
        public ActionResult RegisterAdmins()
        {
            return View();
        }

        //take that input and add to table
        [HttpPost]

        public ActionResult RegisterAdmins(Admin user)
        {
            try
            {
                _adminS.RegisterAdmins(user);
                return RedirectToAction("Login");
            }
            catch
            {
                return RedirectToAction("RegisterAdmins");

            }
        }

        //login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin user)
        {
            bool result = _adminS.Login(user);
            if (result)
            {
                //redirect to dashboard
                return RedirectToAction("Home"); ;
            }
            //stay on same page
            return RedirectToAction("Login");
        }

        //add burgers to database
        [HttpGet]
        public ActionResult AddBurgers()
        {
            return View();
        }

        //take that input and add to table
        [HttpPost]

        public ActionResult AddBurgers(Burger burger)
        {
            try
            {
                _adminS.AddBurgers(burger);
                return View();
            }
            catch (UserExistsException e)
            {
                //1.add alert here
                return StatusCode(500, e.Message);

            }
        }

        public ActionResult Home()
        {
            return View();
        }


    }
}

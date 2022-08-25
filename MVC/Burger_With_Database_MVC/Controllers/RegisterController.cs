using Burger_With_Database_MVC.Models;
using Burger_With_Database_MVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace Burger_With_Database_MVC.Controllers
{
    public class RegisterController : Controller
    {
        readonly IRegisterS _registerS;
        public RegisterController(IRegisterS registerS)
        {
            _registerS = registerS;
        }

        //display page to take input
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }

        //take that input and add to table
        [HttpPost]

        public ActionResult RegisterUser(Register user)
        {
            try
            {
                _registerS.RegisterUser(user);
                 return View();
            }
           catch(UserExistsException e)
            {
                return StatusCode(500,e.Message);
              
            }
        }

        //login
        [HttpGet]
      public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Register user)
        {
            bool result =_registerS.Login(user);
            if (result)
            {
                //1.redirect to dashboard
                return RedirectToAction("Login");
            }
            //stay on same page
           return RedirectToAction("Login");
        }

    }
}

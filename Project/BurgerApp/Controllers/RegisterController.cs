
using BurgerApp.Models;
using BurgerApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace BurgerApp.Controllers
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
                return RedirectToAction("Login");
            }
            catch (UserExistsException e)
            {
                return StatusCode(500, e.Message);

            }
        }
        //login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult User_Home()
        {
            ViewBag.User_Name = HttpContext.Session.GetString("User_Name");
            return View();
        }

        public ActionResult Admin_Home()
        {
            ViewBag.User_Name = HttpContext.Session.GetString("User_Name");

            return View();
        }
    
        [HttpPost]
        public ActionResult Login(Register user)
        {

            Register userLogin = _registerS.LoginUser(user);
            Register adminLogin = _registerS.LoginAdmin(user);
            

            if (userLogin != null)
            {
    
                HttpContext.Session.SetString("User_Name", userLogin.User_Name);
                
                //redirect to user dashboard
                return RedirectToAction("User_Home");
            }
            else if (adminLogin!= null)
                
            {
               
                HttpContext.Session.SetString("User_Name",adminLogin.User_Name);
                //redirect to admin dashboard
                return RedirectToAction("Admin_Home");
            }

            //stay on same page
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }


    }
}

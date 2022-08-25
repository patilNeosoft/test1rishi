using Burger_Project.Models;
using Burger_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Burger_Project.Controllers
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

      
      
    }
}

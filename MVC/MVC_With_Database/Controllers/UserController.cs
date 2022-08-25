using Microsoft.AspNetCore.Mvc;
using MVC_With_Database.Models;
using MVC1.Service;

namespace MVC_With_Database.Controllers
{
    public class UserController : Controller
    {
        readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //get all users
        public ActionResult GetAllUsers()
        {
            List<User> users = _userService.GetAllUsers();
            return View(users);
        }

        //add users in database table
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return RedirectToAction("GetAllUsers");
        }

        //add users in database table
        public ActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction("GetAllUsers");
        }


        //edit details
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = _userService.FindRecordById(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            _userService.Edit(user);
            return RedirectToAction("GetAllUsers");

        }

        public ActionResult Details(int id)
        {
            User user = _userService.FindRecordById(id);
            return View(user);

        }
    }
}

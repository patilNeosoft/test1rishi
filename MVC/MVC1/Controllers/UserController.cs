using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using MVC1.Models;
using MVC1.Repository;

namespace MVC1.Controllers
{
    public class UserController : Controller
    {
        readonly IUserRepo _userRepo;
        readonly UserDbContext _db;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public UserController(UserDbContext db)
        {
            _db = db;
        }
        UserRepo userRepo = new UserRepo();
        //UserClass userClass = new UserClass();
        //create interface object to acces methods
        IUserRepo IUserRepo = (IUserRepo)new UserRepo();


        //public IActionResult GetAllUsers()
        //{
        //    List<UserClass> users = _userRepo.GetAllUsers();
        //    return View(users);
        //}

        public IActionResult GetAllUsers()
        {
            DbSet <UserClass> users = _db.GetAllUsers() ;
            return View(users);
        }



        //create page to take data
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        //create page to insert data
        [HttpPost]
        public ActionResult AddUser(UserClass user)
        {
            _userRepo.AddUser(user);
            return RedirectToAction("GetAllUsers");
        }
        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            UserClass user = _userRepo.FindRecordById(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult DeleteUser(int id, UserClass user)
        {
            _userRepo.DeleteUser(id);
            return RedirectToAction("GetAllUsers");
        }
        [HttpGet]
        public ActionResult UpdateUser(int id)
        {
            UserClass user = _userRepo.FindRecordById(id);


            return View(user);

        }

        [HttpPost]
        public ActionResult UpdateUser(int id, UserClass user)
        {
            _userRepo.UpdateUser(id, user);
            return RedirectToAction("GetAllUsers");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            UserClass user = _userRepo.FindRecordById(id);


            return View(user);

        }




    }
}

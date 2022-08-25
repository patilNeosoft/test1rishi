using BurgerApp.Models;
using BurgerApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class AdminActionsController : Controller
    {
        readonly IRegisterS _registerS;
        public AdminActionsController(IRegisterS registerS)
        {
            _registerS = registerS;
        }
        //AddBurger,DeleteBurger,EditBurger,Logout

        //view all burgers 
        public IActionResult GetAllBurgers()
        {
            List<Burger> burgers = _registerS.GetAllBurgers();
            return View(burgers);

        }

        //add burgers
        [HttpGet]
        public ActionResult AddBurger()
        {
            return View();
        }

        //take that input and add to table
        [HttpPost]

        public ActionResult AddBurger(Burger burger)
        {
            try
            {
                _registerS.AddBurger(burger);
                return RedirectToAction("GetAllBurgers");
            }
            catch (UserExistsException e)
            {
                return StatusCode(500, e.Message);

            }
        }
        //delet burger
        [HttpGet]
        public ActionResult DeleteBurger(int id)
        {
            Burger burger = _registerS.FindRecordById(id);
            return View(burger);
        }
        [HttpPost]
        public ActionResult DeleteBurger(Burger burger)
        {
            _registerS.DeleteBurger(burger.Id);

            return RedirectToAction("GetAllBurgers");
        }

        //edit burger
      
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var burger = _registerS.FindRecordById(id);
            return View(burger);
        }

        [HttpPost]
        public ActionResult Edit(Burger burger)
        {
            _registerS.Edit(burger);
            return RedirectToAction("GetAllBurgers");

        }

    }
}

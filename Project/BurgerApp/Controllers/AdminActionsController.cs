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
                TempData["AddBurger_Alert"] = "Burger added successfully !!";
                return RedirectToAction("GetAllBurgers");
            }
            catch
            {
                return RedirectToAction("AddBurgerEx", "Exceptions");


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
            try
            {
                _registerS.DeleteBurger(burger.Id);
                TempData["DeleteBurger_Alert"] = "Burger Deleted successfully !!";

                return RedirectToAction("GetAllBurgers");
            }
            catch
            {

                return RedirectToAction("DeleteBurgerEx", "Exceptions");
             }

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
            try
            {
                _registerS.Edit(burger);
                TempData["EditBurger_Alert"] = "Burger updated successfully !!";

                return RedirectToAction("GetAllBurgers");

            }
            catch
            {
             return RedirectToAction("EditEx", "Exceptions");

            }

        }

    }
}

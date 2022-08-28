using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class Exceptions : Controller
    {
        public IActionResult AddToCartEx()
        {
            return View();
        }
        public IActionResult BuyEx()
        {
            return RedirectToAction("AddToCartEx");
        }
        public IActionResult RemoveCartItemEx()
        {
            return RedirectToAction("AddToCartEx");
        }
        public IActionResult AddBurgerEx()
        {
            return RedirectToAction("AddToCartEx");
        }
        public IActionResult EditEx()
        {
            return RedirectToAction("AddToCartEx");
        }
        public IActionResult DeleteBurger()
        {
            return RedirectToAction("AddToCartEx");
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}

using BurgerApp.Context;
using BurgerApp.Models;
using BurgerApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class UserActionsController : Controller
    {
        readonly IRegisterS _registerS;
        public UserActionsController(IRegisterS registerS)
        {
            _registerS = registerS;
        }

     


        //view all burgers 
        public IActionResult AllBurgers()
        {
            
            List<Burger> burgers = _registerS.AllBurgers();
            return View(burgers);

        }

        //add burgers to cart
       
        //[HttpGet]
        //public ActionResult AddToCart()
        //{
        //    return View();
        //}

        //take that input and add to table
        
        public ActionResult AddToCart(int id)
        {
            try
            {
                string name = HttpContext.Session.GetString("User_Name");
                _registerS.AddToCart(id,name);
                
                return RedirectToAction("User_Home","Register");
            }
            catch (UserExistsException e)
            {
                return StatusCode(500, e.Message);

            }
        }

        public ActionResult RemoveCartItem(int id)
        {
            try
            {
                var name = HttpContext.Session.GetString("User_Name");
                _registerS.RemoveCartItem(id, name);

                return RedirectToAction("User_Home", "Register");
            }
            catch (UserExistsException e)
            {
                return StatusCode(500, e.Message);

            }
        }

        public ActionResult ViewCart()
        {
            
                var name = HttpContext.Session.GetString("User_Name");
                List<Cart> cart = _registerS.ViewCart(name);
                return View(cart);
               
            }

        //edit cart items
        //[HttpGet]
        //public ActionResult EditCart(int id)
        //{
        //    var cart = _registerS.FindRecordById(id);
        //    return View(cart);
        //}

        //[HttpPost]
        //public ActionResult EditCart(Cart cart)
        //{
        //    _registerS.EditCart(cart);
        //    return RedirectToAction("AllBurgers");

        //}

        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}

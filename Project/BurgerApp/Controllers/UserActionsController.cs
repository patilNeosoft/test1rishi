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

        [HttpGet]
        public ActionResult Buy()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Buy(int id, int Quantity)
        {
            try
            {
                
                string name = HttpContext.Session.GetString("User_Name");
                _registerS.Buy(id, name, Quantity);
                if (true) { 

                    return RedirectToAction("ViewBill");
                }
                else
                {
                    TempData["Buy_Alert"] = "item out of stock!";
                    return RedirectToAction("User_Home");
                }
            }
            catch(Exception e)
            {

                 return StatusCode(Quantity, e.Message);
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

        public ActionResult RemoveFromBill(int id)
        {
                var name = HttpContext.Session.GetString("User_Name");
                _registerS.RemoveFromBill(id, name);

                return RedirectToAction("ViewBill");

            
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

        //public ActionResult PayBill()
        //{
        //    return View();
        //}
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        
        public ActionResult ViewBill()
        {

            var name = HttpContext.Session.GetString("User_Name");
            List<Buy> buy = _registerS.ViewBill(name);
            return View(buy);

        }
        public ActionResult Confirm(int id)
        {
            var User_Name = HttpContext.Session.GetString("User_Name");
            _registerS.History(id,User_Name);
            return View();

        }
    }
}

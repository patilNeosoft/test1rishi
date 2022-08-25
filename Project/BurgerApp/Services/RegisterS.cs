using BurgerApp.Context;
using BurgerApp.Models;

namespace BurgerApp.Services
{
    public class RegisterS:IRegisterS
    {
        RegisterDbContext _dbR;
        List<Burger> burgers;

        public RegisterS(RegisterDbContext dbR)
        {
            _dbR = dbR;
        }

        public void RegisterUser(Register user)
        {
            var userPresent = GetUserByName(user.Name);
            if (userPresent == null)
            {
                _dbR.RegisterUsers.Add(user);
                _dbR.SaveChanges();
            }


        }
        public Register GetUserByName(string name)
        {
            return _dbR.RegisterUsers.Where(u => u.User_Name == name).FirstOrDefault();
        }
        public Register GetUserByPassword(string name)
        {
            return _dbR.RegisterUsers.Where(u => u.Password == name).FirstOrDefault();
        }
        public Burger GetBurgerByName(string name)
        {
            return _dbR.Burgers.Where(u => u.Burger_Name == name).FirstOrDefault();
        }
        public Burger GetBurgerByLocation(string location)
        {
            return _dbR.Burgers.Where(u => u.Burger_Location == location).FirstOrDefault();
        }

        //login 
        public Register LoginAdmin(Register user)
        {
            var userName = GetUserByName(user.User_Name);
            var userPassword = GetUserByPassword(user.Password);
            bool userRole = user.Role;
            if (userName != null && userPassword != null && userRole)
            {
                //change 2
                
                return user;
            }
            return null;

        }
        public Register LoginUser(Register user)
        {
            var userName = GetUserByName(user.User_Name);
            var userPassword = GetUserByPassword(user.Password);
            bool userRole = user.Role;
            if (userName != null && userPassword != null && !userRole)
            {
                return user;
            }
            return null;

        }

        //see all burgers by admin
        public List<Burger> GetAllBurgers(){

            return _dbR.Burgers.ToList();
        }
        //see all burgers by user
        public List<Burger> AllBurgers()
        {

            return _dbR.Burgers.ToList();
        }

        //add burger
        public void AddBurger(Burger burger)
        {
            var burgerNamePresent = GetBurgerByName(burger.Burger_Name);
            var burgerLocationPresent = GetBurgerByLocation(burger.Burger_Location);
            if (burgerNamePresent == null || burgerLocationPresent == null )
            {
                _dbR.Burgers.Add(burger);
                _dbR.SaveChanges();
            }


        }
        
       
        //add burger to cart
        public void AddToCart(int id,string name)
        {
            Burger burger = FindRecordById(id);
                Cart cart = new Cart();
            
                cart.User_Name = name;
                cart.Burger_Id = burger.Id;
                cart.Burger_Name = burger.Burger_Name;
                cart.Burger_Location = burger.Burger_Location;
                cart.Quantity = burger.Quantity;
                cart.Price = burger.Price;
                //cart.Burger_Id = burger.Id;
           
                _dbR.Cart.Add(cart);
                _dbR.SaveChanges();
        }

        //display cart
        public List<Cart> ViewCart(string User_Name)
        {
             return FindRecordByIdAndNameCart1(User_Name);
            
        }
        //remove item from cart
        public void RemoveCartItem(int id,string User_Name)
        {

            Cart cart = FindRecordByIdAndNameCart(id,User_Name);
            _dbR.Cart.Remove(cart);
            _dbR.SaveChanges();
        }
        
        public Cart FindRecordByIdAndNameCart(int id,string User_Name)
        {
            return _dbR.Cart.Where(u => u.Id == id && u.User_Name == User_Name).FirstOrDefault();
        }
        public List<Cart> FindRecordByIdAndNameCart1(string User_Name)
        {
            return _dbR.Cart.Where(u => u.User_Name == User_Name).ToList();
            
        }

        //delete burger 
        public Burger FindRecordById(int id)
        {
            return _dbR.Burgers.Where(u => u.Id == id).FirstOrDefault();
        }

        //find cart itme by id to edit
        public Cart FindRecordByIdInCart(int id)
        {
            return _dbR.Cart.Where(u => u.Id == id).FirstOrDefault();
        }
        public void DeleteBurger(int id)
        {
           {
                Burger burger = FindRecordById(id);
                _dbR.Burgers.Remove(burger);
                _dbR.SaveChanges();
            }
        }


        //edit burger
        public bool Edit(Burger burger)
        {
            _dbR.Entry<Burger>(burger).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbR.SaveChanges();
            return true;
        }

        ////edit cart item
        //public void EditCart(Cart cart)
        //{
        //    _dbR.Entry<Cart>(cart).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        //    _dbR.SaveChanges();
           
        //}
       
    }
}

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
                cart.Img = burger.Img;
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
        public void RemoveFromBill(int id, string User_Name)
        {

            Buy buy =_dbR.Buy.Where(u => u.Id == id && u.User_Name == User_Name).FirstOrDefault();
            _dbR.Buy.Remove(buy);
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

        //generate bill
        public bool Buy(int id, string User_Name, int Quantity)
        {
           
                Cart cart = FindRecordByIdAndNameCart(id, User_Name);
                Buy buy = new Buy();

                buy.User_Name = User_Name;
                buy.Burger_Id = cart.Burger_Id;
                buy.Burger_Name = cart.Burger_Name;
                buy.Burger_Location = cart.Burger_Location;
                buy.Quantity = Quantity;
                buy.Price = cart.Price;
                buy.DateTime = DateTime.Now;
                buy.Img = cart.Img;
                Burger burger = FindRecordById(cart.Burger_Id);
                if (burger.Quantity >= Quantity) { 
                burger.Quantity = burger.Quantity - Quantity;
                    _dbR.Buy.Add(buy);
                    _dbR.SaveChanges();
                    _dbR.Cart.Remove(cart);
                    _dbR.SaveChanges();
                return true;
            }
                
            
            return false;
        }

        

        //view bill
        public List<Buy> ViewBill(string User_Name)
        {

            return _dbR.Buy.Where(u => u.User_Name == User_Name).ToList();
        }

        //history table
        public void History(int id, string User_Name)
        {
            List<Buy> buy = _dbR.Buy.Where(u => u.User_Name.Contains(User_Name)).ToList();
            
            
            int count = _dbR.Buy.Count();
            foreach (Buy item in buy)
            {
                History history = new History();
                history.User_Name = User_Name;
                history.Burger_Id = item.Burger_Id;
                history.Burger_Name = item.Burger_Name;
                history.Burger_Location = item.Burger_Location;
                history.Quantity = item.Quantity;
                history.Price = item.Price;
                history.DateTime = DateTime.Now;
                _dbR.History.Add(history);
                
                _dbR.Buy.Remove(item);
                _dbR.SaveChanges();
            }
            _dbR.SaveChanges();

        }
     }
}

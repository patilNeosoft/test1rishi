using Burger_With_Database_MVC.Context;
using Burger_With_Database_MVC.Models;

namespace Burger_With_Database_MVC.Service
{
    public class AdminS:IAdminS
    {
        RegisterDbContext _dbR;
        List<Admin> users;

        public AdminS(RegisterDbContext dbR)
        {
            _dbR = dbR;
        }
        public void RegisterAdmins(Admin user)
        {
            var userPresent = GetUserByName(user.Name);
            if (userPresent == null)
            {
                _dbR.RegisterAdmins.Add(user);
                _dbR.SaveChanges();
            }


        }
        public Admin GetUserByName(string name)
        {
            return _dbR.RegisterAdmins.Where(u => u.Name == name).FirstOrDefault();
        }
        public Admin GetUserByPassword(string password)
        {
            return _dbR.RegisterAdmins.Where(u => u.Password == password).FirstOrDefault();
        }
        public Burger GetBurgerByLocation(string location)
        {
            return _dbR.Burgers.Where(u => u.BLocation == location).FirstOrDefault();
        }
        public Burger GetBurgerByName(string name)
        {
            return _dbR.Burgers.Where(u => u.BName == name).FirstOrDefault();
        }


        //login 
        public bool Login(Admin user)
        {
            var userName = GetUserByName(user.Name);
            var userPassword = GetUserByPassword(user.Password);
            if (userName != null && userPassword != null)
            {
                return true;
            }
            return false;

        }

        //add burers in database
        //1.create view
        public void AddBurgers(Burger burger)
        {
            var burgerNamePresent = GetBurgerByName(burger.BName);
            var burgerLocationPresent = GetBurgerByLocation(burger.BLocation);


            if (burgerNamePresent == null || burgerLocationPresent == null)
            {
                _dbR.Burgers.Add(burger);
                _dbR.SaveChanges();
            }


        }

        //remove burgers
        public void RemoveBurger(Burger burger)
        {
            
            _dbR.Remove(burger);
            _dbR.SaveChanges();
        }


    }

  
}

 

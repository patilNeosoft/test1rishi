using Burger_With_Database_MVC.Context;
using Burger_With_Database_MVC.Models;

namespace Burger_With_Database_MVC.Service
{
    public class RegisterS:IRegisterS
    {
       
        RegisterDbContext _dbR;
        List<Register> users;

        public RegisterS(RegisterDbContext dbR)
        {
            _dbR = dbR;
        }

        public void RegisterUser(Register user)
        {
            var userPresent = GetUserByName(user.Name);
            if(userPresent == null)
            {
                _dbR.RegisterUsers.Add(user);
                _dbR.SaveChanges();
            }
            
            
        }
        public Register GetUserByName(string name)
        {
            return _dbR.RegisterUsers.Where(u => u.Name == name).FirstOrDefault();
        }
        public Register GetUserByPassword(string password)
        {
            return _dbR.RegisterUsers.Where(u => u.Password == password).FirstOrDefault();
        }


        //login 
        public bool Login(Register user)
        {
           var userName = GetUserByName(user.Name);
           var userPassword = GetUserByPassword(user.Password);
           if(userName != null && userPassword != null)
            {
                return true;
            }
            return false;
           
        }

       
    }
}

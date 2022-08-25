using Burger_Project.Context;
using Burger_Project.Models;

namespace Burger_Project.Services
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
            if (userPresent == null)
            {
                _dbR.RegisterUsers.Add(user);
                _dbR.SaveChanges();
            }


        }
        public Register GetUserByName(string name)
        {
            return _dbR.RegisterUsers.Where(u => u.Name == name).FirstOrDefault();
        }
    }
}

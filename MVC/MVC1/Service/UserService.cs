using MVC1.Models;
using MVC1.Repository;

namespace MVC1.Service
{
    public class UserService
    {
        readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public List<UserClass> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }
    }
}


using MVC_With_Database.Models;
using MVC_With_Database.Repository;
using MVC1.Service;

namespace MVC_With_Database.Service
{
    public class UserService : IUserService
    {
        readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public bool AddUser(User user)
        {
            var userPresent = _userRepo.GetUserByName(user.Name);
            if (userPresent == null)
            {
                return _userRepo.AddUser(user);
            }

            return false;


        }

        public bool DeleteUser(int id)
        {
            var userPresent = _userRepo.FindRecordById(id);
            if (userPresent != null)
            {
                return _userRepo.DeleteUser(id);
            }

            return false;


        }
        //edit
        public void Edit(User user){
            _userRepo.Edit(user);

            }

        public User FindRecordById(int id)
        {
            return _userRepo.FindRecordById(id);
 }
        bool IUserService.Edit(User user)
        {
            return _userRepo.Edit(user);
        }

        public User Details(int id)
        {
            return _userRepo.Details(id);
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }
       
    }
}

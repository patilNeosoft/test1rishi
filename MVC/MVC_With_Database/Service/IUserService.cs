using MVC_With_Database.Models;

namespace MVC1.Service
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        bool AddUser(User user);
        bool DeleteUser(int id);
        bool Edit(User user);
        User FindRecordById(int id);
    }
}



using MVC_With_Database.Models;

namespace MVC_With_Database.Repository
{
    public interface IUserRepo
    {
        List<User> GetAllUsers();

        List<User> AddUser();

        bool AddUser(User user);

        bool DeleteUser(int id);

        User FindRecordById(int id);

        User Details(int id);
        User GetUserByName(string name);
        bool Edit(User user);
    }
}

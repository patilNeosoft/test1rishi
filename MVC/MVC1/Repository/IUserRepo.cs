using MVC1.Models;

namespace MVC1.Repository
{
    public interface IUserRepo
    {
        List<UserClass> GetAllUsers();
        List<UserClass> AddUser();
        void AddUser(UserClass user);
        void DeleteUser(int id);
        UserClass FindRecordById(int id);
        //void Details();
        void UpdateUser(int id, UserClass user);
        
    }
}

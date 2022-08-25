using MVC1.Models;

namespace MVC1.Repository
{
    public class UserRepo:IUserRepo
    {

        List<UserClass> users;
        public UserRepo()
        {
            users = new List<UserClass>() {new UserClass { Id=1,Name="Pooja",Age=22} };
              
        }
        public List<UserClass> GetAllUsers()
        {
            return users;
        }

        public List<UserClass> AddUser()
        {
            return users;
        }

        public void AddUser(UserClass user)
        {
            users.Add(user);
        }


        public void DeleteUser(int id)
        {
            UserClass user = FindRecordById(id);
            users.Remove(user);
        }
        public UserClass FindRecordById(int id)
        {
            return users.Find(item => item.Id == id);
        }
        public void UpdateUser(int id, UserClass user)
        {
            UserClass user1 = FindRecordById(id);
            user1.Name = user.Name;
            user1.Id = user.Id;
            user1.Age = user.Age;
        }

        public UserClass Details(int id)
        {
            UserClass users = FindRecordById(id);
            return users;
        }


    }
}

using MVC_With_Database.Models;
using MVC1.Context;

namespace MVC_With_Database.Repository
{
    public class UserRepo:IUserRepo
    {
        UserDbContext _userDbContext;
        List<User> users;

        public UserRepo(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public List<User> GetAllUsers()
        {
           return _userDbContext.users.ToList();
        }

         public List<User> AddUser()
        {
            return users;
        }

       
        
        //find name in table
        public User GetUserByName(string name)
        {
            return _userDbContext.users.Where(u => u.Name == name).FirstOrDefault();
        }

        //add user in table
        public bool AddUser(User user)
        {
            _userDbContext.users.Add(user);
            return _userDbContext.SaveChanges() == 1 ? true : false;       }


      
        //get details
        public User Details(int id)
        {
          User users = FindRecordById(id);
          return users;
        }

        public bool DeleteUser(int id)
        {
            User user = FindRecordById(id);
            _userDbContext.users.Remove(user);
            return _userDbContext.SaveChanges() == 1 ? true : false;
       
        }
        public User FindRecordById(int id)
        {
            return _userDbContext.users.Where(u => u.Id == id).FirstOrDefault();
        }

        //edit
        public bool Edit(User user)
        {
          _userDbContext.Entry<User>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
         _userDbContext.SaveChanges();
            return true;
        }

       

    }
}

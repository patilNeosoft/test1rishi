using Microsoft.EntityFrameworkCore;
using MVC_With_Database.Models;


namespace MVC1.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>Context ):base(Context)
        {

        }
        public DbSet<User> users { get; set;}

        public DbSet<User> GetAllUsers()
        {
            return users;
        }
    }
}

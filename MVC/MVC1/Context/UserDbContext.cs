using Microsoft.EntityFrameworkCore;
using MVC1.Models;

namespace MVC1.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>Context ):base(Context)
        {

        }
        public DbSet<UserClass> users { get; set;}

        public DbSet<UserClass> GetAllUsers()
        {
            return users;
        }
    }
}

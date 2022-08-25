using Cache.Models;
using Microsoft.EntityFrameworkCore;

namespace Cache.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> Context) : base(Context)
        {

        }
        public DbSet<User> UserTb { get; set; }

    }
}

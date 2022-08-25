using Burger_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Burger_Project.Context
{
    public class RegisterDbContext:DbContext
    {
      
        public RegisterDbContext(DbContextOptions<RegisterDbContext> Context) : base(Context)
        {
          
        }

        public DbSet<Register> RegisterUsers { get; set; }
       


    }
}

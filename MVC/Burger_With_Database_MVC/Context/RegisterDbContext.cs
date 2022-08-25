using Burger_With_Database_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burger_With_Database_MVC.Context
{
    public class RegisterDbContext:DbContext
    {
      
        public RegisterDbContext(DbContextOptions<RegisterDbContext> Context) : base(Context)
        {
          
        }

        public DbSet<Register> RegisterUsers { get; set; }
        public DbSet<Admin> RegisterAdmins { get; set; }

        public DbSet<Burger> Burgers { get; set; }


    }
}

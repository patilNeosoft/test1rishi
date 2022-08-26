using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerApp.Context
{
    public class RegisterDbContext:DbContext
    {
        internal object burgers;

        public RegisterDbContext(DbContextOptions<RegisterDbContext> Context) : base(Context)
        {

        }

        public DbSet<Register> RegisterUsers { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Buy> Buy { get; set; }

       
    }
}

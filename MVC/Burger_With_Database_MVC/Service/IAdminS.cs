using Burger_With_Database_MVC.Models;

namespace Burger_With_Database_MVC.Service
{
    public interface IAdminS
    {
        void RegisterAdmins(Admin user);
        bool Login(Admin user);
        void AddBurgers(Burger burger);
    }
}

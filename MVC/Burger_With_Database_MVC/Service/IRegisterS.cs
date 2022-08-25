using Burger_With_Database_MVC.Models;

namespace Burger_With_Database_MVC.Service
{
    public interface IRegisterS
    {
        void RegisterUser(Register user);
        bool Login(Register user);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration1.Model;

namespace UserRegistration1.Repository
{
    internal interface IUserRepo
    {
       public bool Register(User user);
    }
}

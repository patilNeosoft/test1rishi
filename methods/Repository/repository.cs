using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods.Repository
{
    internal class repository
    {
        internal void Login(string username, string password) {

            if ((username == null || username == "") && (password == null || password == ""))
            {
                Console.WriteLine("fill the data");
            }

            else if (username == "user1" && password == "user1")
            {
                Console.WriteLine("login success");
            }
            else {
                Console.WriteLine("invalid");
            }
 
    }
    }
}

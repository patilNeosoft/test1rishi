using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void Process();
    internal class Delg
    {

        public void Mainfunction(Process handler) {
            Console.WriteLine("wait...Numbers are printing");
            handler();
            
        }
    }
}

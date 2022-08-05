using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismExe
{
    internal class Book
    {
        public void ViewDetails(string name, string author) {
            Console.WriteLine($"{name}\t{author}");
        }
        public void ViewDetails(string name, string author,int price)
        {
            Console.WriteLine($"{name}\t{author}\t{price}");
        }
        public virtual string OrderStatus() {
            return "parent class";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismExe
{
    internal class Ebook:Book
    {
        public override string OrderStatus() {
            return "child class";

        }
    }
}

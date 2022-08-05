using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExe
{
    internal class Child:InterfaceExe
    {
        public void Calculator(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"addition is :{c}");
        }
    }
}

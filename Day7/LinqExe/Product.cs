using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExe
{
    internal class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } 
        public int Price { get; set; }

        public override string ToString()
        {
            return ($"Name : {Name},Category :{Category},Price :{Price}");
        }
    }
}

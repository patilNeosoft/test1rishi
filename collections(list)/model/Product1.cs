using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_list_.model
{
    internal class Product1
    {

        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return ($"Name : {Name} Quantity : {Quantity}");
        }
    }
}


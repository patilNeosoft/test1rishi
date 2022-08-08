using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_list_.model
{
    internal class Product
    {
        public int Id { get; set; } 

        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return ($"Id : {Id} Name : {Name}  Price: {Price}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Model
{
    internal class Burger
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}

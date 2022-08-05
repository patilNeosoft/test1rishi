using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling.Model
{
    internal class User
    {
        public User(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;

        }

        public int id { get; set; }
        public string name { get;set; }
        public string city { get;set; }
    }
}

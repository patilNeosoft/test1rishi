using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return ($"{Id},{Name},{City}\n");
        }
    }
}

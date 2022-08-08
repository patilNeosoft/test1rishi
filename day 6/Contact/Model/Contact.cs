﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTask.Model
{
    internal class Contact

    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }  

        public override string ToString()
        {
            return ($"Name: {Name} Address : {Address}  City: {City} Phone: {Phone}");
        }
   
}
}

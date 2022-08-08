﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSortedList
{
    internal class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    

        public int Age { get; set; }

        public override string ToString()
        {
            return($"id : {Id},Name : {Name},Age : {Age}");
        }
    }
}

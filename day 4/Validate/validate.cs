using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validate
{
    internal class validate
    {
        public const string mobile = @"^[+]?91[-\s]?[6-9][0-9]{9}$";
        
        //to check phone number
        public bool test2(string number)
        {
            if (number != null) 
                return Regex.IsMatch(number, mobile);
            else
                return false;
        }
        //to check email id
        public bool test1(string password)
        {
            if (password != null)
                return Regex.IsMatch(password,Password);
            else
                return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Model;
namespace ContactTask.Repository
{
    internal class ContactRepo
    {
        //declare list
        List<Contact> contacts;
        public ContactRepo()
        {
            contacts = new List<Contact>() {
                new Contact(){Name="pooja",Address="abs",City="navi mumbai",Phone="6767676767"},
                new Contact(){Name="payal",Address="abv",City="mumbai",Phone="9067676767"}

            };
        }
        public List<Contact> GetProducts()
        {
            return contacts;
        }

    }
}

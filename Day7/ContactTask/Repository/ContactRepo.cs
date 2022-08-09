using ContactTask.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTask.Repository
{
    internal class ContactRepo
    {
        List<Contact> contacts;
        public ContactRepo()
        {
            contacts = new List<Contact>() {
                new Contact(){Name="pooja",Address="room 102,omsai building,rabale",City="mumbai",Phone="8989898989"},
                new Contact(){Name="payal",Address="107,ram nivas,vashi",City="mumbai",Phone="8989898989"}

            };
        }

        //get contacts
        public List<Contact> GetContacts()
        {
            return contacts;
        }

        //Add 
        public string Addcontact(Contact contact)
        {
            //check whether product exists in list or not
            var res = GetContactsByName(contact.Name);
            if (res == null)
            {
                contacts.Add(contact);
                return $"Contact added successfully";
            }

            else
            {
                throw new Exception($"{contact.Name} Already exists");
            }
        }
        public Contact GetContactsByName(string name)
        {
            return contacts.Find(p => p.Name == name);

        }

        //delete contact
        public bool DeleteContact(string name)
        {
            //get product name in res1
            var contact = GetContactsByName(name);
            //if name is present then remove product
            return contact != null ? contacts.Remove(contact) : false;

        }

        //update contact
        public string UpdateContact(Contact Newc,string name)
        {
            Contact NewC = new Contact() { Name = "uday", Address = "sai nivas,room 101,navi mumbai", City = "pune", Phone = "9876564537" };

            var res = GetContactsByName(name);
            if (res != null)
            {
                var contactC = GetContactsByName(name);
                    contactC.Name = NewC.Name;
                    contactC.Address = NewC.Address;
                    contactC.City = NewC.City;
                    contactC.Phone = NewC.Phone;
                return $"Itme updated" ;


            }
            else {
                throw new Exception($"{NewC.Name} does not Already exists");
            }
            }
        //filter names
        public List<Contact> GetAllContactsByName(string name)
        {
            return contacts.FindAll(p => p.Name == name);


        }

    }
}

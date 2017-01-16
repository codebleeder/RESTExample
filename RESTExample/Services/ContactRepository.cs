using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTExample.Models;

namespace RESTExample.Services
{
    public class ContactRepository
    {
        Contact[] contacts;
        List<Contact> lContacts; 

        public ContactRepository()
        {
            //this.contacts =  new Contact[] { new Contact { id = 1, name = "Sharad" }, new Contact { id = 2, name = "Surabhi" } };
            lContacts = new List<Contact>();
            lContacts.AddRange(new Contact[] { new Contact { id = 1, name = "Sharad" }, new Contact { id = 2, name = "Surabhi" } });
        }
        public Contact[] GetAllContacts()
        {
            return lContacts.ToArray<Contact>();
        }
        public bool SaveContact(Contact oContact)
        {
            try
            {
                lContacts.Add(oContact);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }
    }
}
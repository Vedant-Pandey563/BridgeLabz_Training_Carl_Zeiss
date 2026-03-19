using System;
using System.Collections.Generic;
using System.Text;

namespace Review4TechnicalAddressBook
{
    public class ContactList
    {
        private List<Contact> contacts;

        public ContactList()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        public void DisplayAll()
        {
            Console.WriteLine("Contact List:");

            foreach (Contact c in contacts)
            {
                Contact.DisplayContact(c);
            }
        }
    }
}
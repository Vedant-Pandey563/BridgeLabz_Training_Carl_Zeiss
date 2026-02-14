using System;
using System.Collections.Generic;
using System.Text;

namespace Review4TechnicalAddressBook
{
    public class AddressBook
    {
        private Dictionary<char, List<Contact>> book;

        public AddressBook()
        {
            book = new Dictionary<char, List<Contact>>();
        }

        public void AddContact(Contact contact)
        {
            char key = contact.Name[0];

            if (!book.ContainsKey(key))
            {
                book[key] = new List<Contact>();
            }

            book[key].Add(contact);
        }

        public void DisplayAll()
        {
            Console.WriteLine("Address Book:");

            foreach (var entry in book)
            {
                Console.WriteLine($"Contacts starting with {entry.Key}:");

                foreach (Contact c in entry.Value)
                {
                    Contact.DisplayContact(c);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Review4TechnicalAddressBook
{
    public class Contact
    {
        private static int i = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }

        public Contact(string name, string email, long phone, string address)
        {
            Id = i++;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public static void DisplayContact(Contact c)
        {
            Console.WriteLine("Contact Details");
            Console.WriteLine($"ID: {c.Id}");
            Console.WriteLine($"Name: {c.Name}");
            Console.WriteLine($"Email: {c.Email}");
            Console.WriteLine($"Phone Number: {c.Phone}");
            Console.WriteLine($"Address: {c.Address}");
        }
    }
}

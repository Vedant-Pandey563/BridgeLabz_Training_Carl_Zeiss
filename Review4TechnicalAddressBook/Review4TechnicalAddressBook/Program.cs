/*
 * Problem Statement: Address Book Application

ContactPerson Fields:

Id

Name

Email

Phone Number

Address

Constraints:

The Email must be unique within the application.

The Id should be auto-generated.

Application Requirements

Create a C# console-based Address Book application with the following requirements:

Create a data structure to store contacts where:

The key is the first character of the contact’s first name.

The value is a list of contacts.

Dictionary<char, List<ContactPerson>>


Add contacts to the dictionary such that each contact is inserted based on the first letter of their first name.

Display contacts according to the character entered by the user.
 */

namespace Review4TechnicalAddressBook
{




    /*public void UniqueMail(string temp)
    {
        string temp = Console.ReadLine();
        HashSet<string> emailset = new HashSet<string>();
        if (HashSet.Contains(temp))
        {
            Console.WriteLine("Duplicate email id , Enter a vlaid email id");
        }
        else
        {
            HashSet.Add(temp);
        }
    }
    */


    /*class ContactList
    {
        contact c = new contact();
        List<Contact> list = new List<Contact>();

    }
    */

    /*class AddressBook
    {
        contact c = new contact();

        List<contact> l = new List<contact>();

       Dictionary<char,l> addressbook = new Dictionary<char,List>();


    }*/

    class Program
    {
        static Contact GetContact()
        {
            Console.WriteLine("Enter Contact Details");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone: ");
            long phone = long.Parse(Console.ReadLine());

            Console.Write("Address: ");
            string address = Console.ReadLine();

            return new Contact(name, email, phone, address);
        }

        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();
            AddressBook addressBook = new AddressBook();

            Contact c1 = GetContact();
            Contact c2 = GetContact();

            contactList.AddContact(c1);
            contactList.AddContact(c2);

            addressBook.AddContact(c1);
            addressBook.AddContact(c2);

            Console.WriteLine("List Display");
            contactList.DisplayAll();

            Console.WriteLine("Dictionary Display");
            addressBook.DisplayAll();

            Console.ReadLine();
        }
    }
}

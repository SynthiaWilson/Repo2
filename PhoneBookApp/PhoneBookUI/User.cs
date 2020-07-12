using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookUI
{
    public static class User
    {
        public static void ReadAllContacts()
        {
           // foreach (var c in PhoneBook.ContactList)
           // {
                Console.WriteLine("the names and numbers");
           // }

        }
        public static string Response { get; set; }

        public static Contact CreateContact()
        {
            Contact c = new Contact();
            
           
            Console.WriteLine("Please enter the contacts first name.\n");
            c.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter the contacts last name.\n");
            c.LastName = Console.ReadLine();

            Console.WriteLine("Please enter the telephone number.\n");
            c.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Please enter the email address.\n");
            c.Address = Console.ReadLine();

            Console.WriteLine("Please enter the address.\n");
            c.Address = Console.ReadLine();

            Console.WriteLine("Please enter the date of birth dd/mm/yyyy\n");
            c.DOB = Console.ReadLine();

            return c;
        }
            
    }
}

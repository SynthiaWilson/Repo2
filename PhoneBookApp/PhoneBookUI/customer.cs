using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookUI
{
    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Address{ get; set;}
        public string DOB { get; set; }

        public string Create()
        {
            Console.WriteLine("Please enter the contacts first name.\n");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter the contacts last name.\n");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter the telephone number.\n");
            string phone = Console.ReadLine();

            Console.WriteLine("Please enter the email address.\n");
            string eAddress = Console.ReadLine();

            Console.WriteLine("Please enter the address.\n");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter the date of birth dd/mm/yyyy\n");
            string dob = Console.ReadLine();
            
            return ($"{fName}^{lName}^{phone}^{eAddress}^{dob}");
        }
    }
}

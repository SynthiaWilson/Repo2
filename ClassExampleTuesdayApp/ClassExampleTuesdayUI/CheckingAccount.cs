using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExampleTuesdayUI
{
    public class CheckingAccount
    {
        // Properties
        
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set 
            {
                Console.WriteLine("Please enter you pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Not pin");
                    return;
                }

            }
        }
        public string AccountNumber { get; set; }

        private string _routingNumber;
        public string RoutingNumber
        {
            get
            {
                return _routingNumber;
            }

            set
            {
                if (value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Routing Number Invalid");
                }

            }

        }
        public Customer Owner { get; set; }
        public void PrintBalance()
        {
            Console.WriteLine($"Your current balance is {Balance}");
        }

    }
}

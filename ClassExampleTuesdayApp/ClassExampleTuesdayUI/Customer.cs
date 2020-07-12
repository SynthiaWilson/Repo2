using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassExampleTuesdayUI
{
    public class Customer
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }

        public CheckingAccount UserCheckingAccount { get; set; }

        // Default Ctor
        public Customer()
        { }

        //Parameterized Ctor
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deposit(decimal amount)
        {
            UserCheckingAccount.Balance += amount;
        }
        public void Withdraw(decimal amount)
            {
                UserCheckingAccount.Balance -= amount;
            }

        }
}

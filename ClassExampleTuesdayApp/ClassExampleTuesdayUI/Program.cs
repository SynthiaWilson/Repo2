using System;

namespace ClassExampleTuesdayUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            //Customer c = customer;
            Console.WriteLine("Please give me your name");
            c.FirstName = Console.ReadLine();

            Console.WriteLine("Please give me your last name");
            c.LastName = Console.ReadLine();

            Console.WriteLine($" Hello {c.FirstName} {c.LastName}");
            Console.WriteLine("Please enter you age");
            c.Age = int.Parse(Console.ReadLine());

            if (c.Age > 18)
            {

                CheckingAccount checkingAccount = new CheckingAccount();
                checkingAccount.RoutingNumber = "654000457";
                checkingAccount.AccountNumber = "12345";

                checkingAccount.Owner = c;
                c.UserCheckingAccount = checkingAccount;

                Console.WriteLine($"You're new checking acct number is {checkingAccount.AccountNumber} for a bank account");
                Console.WriteLine($"The owner of the account is {checkingAccount.Owner.FirstName} {checkingAccount.Owner.LastName}");


            }
            else
            {
                Console.WriteLine("You're to young for a bank account");
                return;
            }
            Console.WriteLine("Do you want to deposit or withdraw money?");
            string userResponse = Console.ReadLine();
            decimal amount;

            switch (userResponse)
            {
                case "deposit":

                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());

                    c.Deposit(amount);
                    c.UserCheckingAccount.PrintBalance();

                    break;


                case "withdraw":

                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Withdraw(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;


            }



        }
    }
}

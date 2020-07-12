using System;
using System.Globalization;

namespace BankEncapsulationUI
{
    class Program
    {
        static void Main(string[] args)
        {


            BankAccount bankAccount = new BankAccount();
            Console.WriteLine("Enter the amount for a deposit:");

            double amount;
            amount = double.Parse(Console.ReadLine());

            bankAccount.Deposit(amount);
            Console.WriteLine($" This is your balance {bankAccount.GetBalance(), 0:c} ");


            PersonalInformation personal = new PersonalInformation();
            Console.WriteLine("Enter you digits... pretty please");
            //double digits;
            personal.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your formatted digits: {personal.NumberFormatted} ");

        }
    } 
        
}

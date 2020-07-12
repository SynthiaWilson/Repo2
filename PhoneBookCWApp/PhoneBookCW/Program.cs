﻿using System;

namespace PhoneBookCW
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogging.IntroText();
            int contactId;
            do
            {
                Console.Clear();
                ConsoleLogging.WhichActionText();
                var userChoice = Console.ReadKey();
                Console.WriteLine();
                switch (userChoice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        PhoneBook.CreateContact(PhoneBook.ContactList.Count);
                        ConsoleLogging.PressEnter();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        PhoneBook.GetAllContacts();
                        ConsoleLogging.PressEnter();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        contactId = ConsoleLogging.GetContactToUpdate();
                        PhoneBook.UpdateContact(contactId);
                        ConsoleLogging.PressEnter();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        contactId = ConsoleLogging.GetContactToDelete();
                        PhoneBook.DeleteContact(contactId);
                        ConsoleLogging.PressEnter();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                      //  FileMaster.WriteFile(PhoneBook.ContactList);
                        Console.WriteLine("Thank You!");
                        Environment.Exit(0);
                        break;
                }

            } while (true);


        }
    }
}

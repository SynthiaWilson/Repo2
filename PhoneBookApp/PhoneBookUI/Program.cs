using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace PhoneBookUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Contact> dict3 = new Dictionary<int, Contact>();

            //**** Dictionary *******
            //    IDictionary<int, string> dict = new Dictionary<int, string>()
            //    {
            //       {1,"Cindy^Wilson^256-777-3885^cindywilson@gmail.com^111 Main St.^03/09/1982"},
            //        {2,"John^Doenut^404-333-1234^johnedoe@gmail.com^222 Wood St.^05/05/2005"},
            //        {3,"Karen^Kroutch^950-333-1111^karen@gmail.com^555 River Rd.^08/08/1988"},
            //       {8,"David^Duke^833-999-8765^dd@yahoo@gmail.com^321 Morning GLory^09/09/1999" }
            //   };


            //foreach (KeyValuePair<int, string> item in dict)
            //{
            //    Console.WriteLine("Key: {0}, Value {1}", item.Key, item.Value);
            //}
            //**** End of Temp Dictionary

            //dic2..PrintDict();
            //******************************************************************



            PhoneBook.ContactLit.Add(new Contact()
            {
                FirstName = "Cindy",
                LastName = "Wilson",
                PhoneNumber = "204-766-3885",
                Address = "666 Hope St.",
                DOB = "01/01/2020",
                Email = "cinwil@gmail.com"
            });
            PhoneBook.ContactLit.Add(new Contact()
            {
                FirstName = "Brian",
                LastName = "Culvert",
                PhoneNumber = "256-383-5666",
                Address = "321 Huckleberry St.",
                DOB = "10/15/1999",
                Email = "huck@gmail.com"
            });

            //string result = "";


            /// Set up a repeating Menu to exit on 5 ////
            bool showMenu = true;

            while (showMenu)
            {
                
                showMenu = MainMenu(dict3);
            }
                
            
            
        }
        //************************Main Menu**************************************
        static bool MainMenu(IDictionary<int,Contact> d)
        {
               // Contact c2 = new Contact();
                int addkey = 0;


                Console.Clear();
                Console.WriteLine("Welcome to your phone book!\n");
                Console.WriteLine("What action would you like to perform\n");
                Console.WriteLine("1. - Create as contact\n");
                Console.WriteLine("2. - Read all contacts\n");
                Console.WriteLine("3. - Update a contact\n");
                Console.WriteLine("4. - Delete a contact\n");
                Console.WriteLine("5. - End Application\n");
                Console.WriteLine("Select an option: ");

                int input = int.Parse(Console.ReadLine());
  

                Console.WriteLine($"Input is {input}");

                switch (input)
                {

                    case 1:

                    Contact c2  = User.CreateContact();
                    PhoneBook.ContactLit.Add(c2);

                    // Find a Unique Key to insert in the Dictionary
                    addkey = 0;
                    foreach (KeyValuePair<int, Contact> item in d)
                    {
                        if (item.Key > addkey)
                        {
                            addkey = item.Key;
                            addkey++;
                        }
                    }
                    Console.WriteLine($"insert addkey  {addkey}");
                    if (d.ContainsKey(addkey) == false)
                    {
                        d.Add(new KeyValuePair<int, Contact>(addkey, c2));
                        Console.WriteLine($"add, {addkey} {c2.FirstName} {c2.LastName}");

                    }

                    // Insert the values and the key into the Dictionary
                    Console.WriteLine("This is the add:");
                    Console.WriteLine("Count: {0}", d.Count);
                    // var dictC = d.Values
                    //  Console.WriteLine(d.Value.c2.FirstName>, c2.LastName, c2.PhoneNumber);
                    Console.WriteLine(d[0].FirstName );

                    Console.WriteLine("Press a key to continue...");
                    Console.ReadKey();
                    return true;

                    case 2:
                    // Read all contacts
                    Console.WriteLine("_____Customer List______");


                    menuCustomer(d);
                    

                    Console.WriteLine("Press a key to continue...");
                    Console.ReadKey();
                    return true;

                    case 3:
                    // Update a contact

                    Console.WriteLine("Press a key to continue...");
                    Console.ReadKey();
                    return true;

                    case 4:
                    // Delete a contact
                    int[,] keyA = new int[500,2];

                    int k = 1;
                    foreach (KeyValuePair<int, Contact> item in d)
                    {
                        keyA[k,0] = k;
                        keyA[k,1] = item.Key;
                        Console.WriteLine($"{keyA[k, 0]}. - {keyA[k, 1]}");
                        k++;
                
                    }

                    

                    Console.WriteLine("Press a key to continue...");
                    Console.ReadKey();
                    return true;

                    case 5:
                    // End Application
                    Console.WriteLine("End the application. GoodBye!");
                    return false;

                     default:
                    Console.WriteLine("Not a valid selection?");
                    return true;
                }

            static void menuCustomer(IDictionary<int, Contact> d)
            {
                int i = 1;
                foreach (KeyValuePair<int, Contact> item in d)
                {
                    Console.Write($"{i}. ");

                    Console.WriteLine(item.Value.FirstName,item.Value.LastName,item.Value.PhoneNumber);
                    i++;
                }
               // int i = 1;
               // string[] custA = new string[20];
                // string[] custA = new string[200,6]();

               // foreach (KeyValuePair<int, > item in d)
               // {
               //     custA = item.Value.Split('^');
               //     Console.Write($"{i}. ");
               //     for (int j = 0; j < custA.Length; j++)
                //    {
                //        Console.Write($"{custA[j]}  \t");
               ///    Console.WriteLine();

                  //  i++;
                


            }



        }





    }
}
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PhoneBookUI
{
    public static class Diction
    {

        //public Dictionary<int, Contact> Dict4 = new Dictionary<int, Contact>();

        public static Dictionary<int, Contact> dict4 = new Dictionary<int, Contact>();
        
       
            
              //  {1,"Cindy^Wilson^256-777-3885^cindywilson@gmail.com^111 Main St.^03/09/1982"},
             //   {3,"Karen^Kroutch^950-333-1111^karen@gmail.com^555 River Rd.^08/08/1988"},
             //   {8,"David^Duke^833-999-8765^dd@yahoo@gmail.com^321 Morning GLory^09/09/1999" }
        

        public static void PrintDict()
        {
            foreach (KeyValuePair<int, Contact> item in dict4)
            {
                Console.WriteLine("Key: {0}, Value {1}", item.Key, item.Value);
            }
                //**** End of Temp Dictionary2
        }
        
    }
}


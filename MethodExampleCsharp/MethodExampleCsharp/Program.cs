using System;

namespace MethodExampleCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();

             MyMethod("Hello world");

            var message = MyMessage(userName, userAge);
        }
        public static void MyMethod(string text)
        {
            Console.WriteLine(text);

        }
        public static string MyMessage(string name, string age)
        {
            //Hello username, how does it feel to be their age ? 
            return "$Hello {name}, how does it feel to be their {age}?";


        
    }
    }
}

using System;
using System.ComponentModel;

namespace ModuleExer2
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



        //nsole.WriteLine("Enter number1");
        //int n1 = Console.ReadLine();
        int n1 = 10;

            Console.WriteLine("Enter number2");
            //int n2 = Console.ReadLine();
            int n2 = 20;
            var result = Add(n1, n2);
            Console.WriteLine($"The sum of {n1} and {n2} = {result}");

            Console.WriteLine($"The multiplication of {n1} and {n2} = {result}");
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}

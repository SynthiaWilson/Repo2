using System;

namespace OverLoadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

    

            Console.WriteLine($" The integer sum is {sum(3,56)}");
            Console.WriteLine($" The decimal sum is {sum(5.0m, 3.44m)}");
            Console.WriteLine($" The money sum is {sum(11, 13, true)}");
        }

        static int sum(int a, int b)
        {
            return a + b;
        }
        static decimal sum(decimal a, decimal b)
        {
            return a + b;
        }

        static string sum(int a, int b, bool Flag) 
        {
            string dollarSign = "";
            if (Flag == true)
            {
                if (a + b > 1)
                { dollarSign = " dollars"; }
                else { dollarSign = " dollar"; }
            }
            int add1 = a + b;
            return $"{a + b} {dollarSign}";

        }

    }
}

using System;

namespace Throwaway
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 32;
            int b = 5;
            var quotient = a / b;
            var remainder = a % b;

            // int sum = a + b;
           // AddItUp(a, b);
            //int prod = a * b;
           // MultItUp(a, b);
            int neg = a - b;

            


            Console.WriteLine($"The {a}/{b} quotient is {quotient} with the remainder {remainder}");
            //    var radius = double.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            // Console.WriteLine(x--);

            // Console.WriteLine(x);
            //x += 5;
            //Console.WriteLine(x);


            //var radius = double.Parse(Console.ReadLine());
            //
           // usAreaofCircle(radius);

            //var i = int.Parse(Console.ReadLine());
            //var j = int.Parse(Console.ReadLine());
            //FunkyIncrements(i, j);

            //string greet1 = myGreet("John Doe");
            //Console.WriteLine(greet1);
            char cc = 'a';

            //if (CharacterIsALetter(cc))
            //    {
                        Console.WriteLine($" This {cc} is a Character ");
            //    }


        }
        public static void AddItUp(int x, int y)
        {
            var sum = x + y;
            Console.WriteLine($"+++++The sum of {x} and {y} is {sum}");

        }
        public static void MultItUp(int x, int y)
        {
            var prod = x * y;
            Console.WriteLine($"****The product of {x} and {y} is {prod}");

        }
        public static void AreaofCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"The area of a circle with the radius {r} is {area}");

        }
            public static void FunkyIncrements(int num1, int num2)
            {
            Console.WriteLine($"Before the operation Number1 is {num1} and Number2 is {num2} ");
            var answer  = ++num1 * num2++;
                Console.WriteLine($"Number1 {num1} and {num2} answer is {answer}");

        }

        public static string myGreet(string nameOfPerson)
        {
            if (nameOfPerson != "")
            {
                string greeting = ($"Hello, {nameOfPerson}!");

                return greeting;
            }
            else
            {
                return "Hello!";
            }
        }


         public bool CharacterIsALetter(char c)
         {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            // Check all letters
            foreach (char letter in lowercaseAlphabet)
            {
                if ((c == letter) ||
                     (c == char.ToUpper(letter)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;

                

        }
        }
    }

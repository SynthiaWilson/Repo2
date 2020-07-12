using System;
using System.Security.Cryptography.X509Certificates;

namespace RandomEx2fromLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numberList = new List<int>();

            //  numberList.Add(1);
            //  numberList.Add(2);
            //  numberList.Add(3);
            //  numberList.Add(4);
            //  numberList.Add(5);

            //    foreach (int number in numberList)
            //    {
            //        Console.WriteLine(number);
            //    }


            // Call 
            // Call the NumberPrinter

            NumberPrinter();
            Console.ReadLine();

            //    Console.WriteLine("Hello World!");
            Console.WriteLine("Please give me a number!!");
            int userInput = int.Parse(Console.ReadLine());
            int[] array = ArrayCreator(userInput);

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }

        public static void NumberPrinter()
        {
            for (int i = 100; i >= -100; i--)
                Console.WriteLine(i);
        }

        //***************************************************

        public static int[] ArrayCreator(int userNumber)
        {
            int[] customArray = new int[userNumber];

            Random rng = new Random();
            for (int index = 0; index < customArray.Length; index++)
            {
                customArray[index] = rng.Next(100);
            }
            return customArray;
        }
        //////// Declare a method
        public static void ThreePrinter()
        {
            int i = 3;
            while (i < 999)
            {
                i += 3;
            }


        }
        
        
    }
}

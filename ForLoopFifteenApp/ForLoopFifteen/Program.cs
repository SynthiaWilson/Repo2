using System;

namespace ForLoopFifteen
{
    class Program
    {
        static void Main(string[] args)
        {

            //For1
            Console.WriteLine("For1 ! Bless your heart");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i} burp");

            }

            //For2
            Console.WriteLine(" For 2 Froggies");

            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine($"{j} Rippet");
            }
            //For3
            Console.WriteLine(" How many Katydids? For3");
            for (int k = 11; k > 1; k--)
            {
                Console.WriteLine($"{k} Holler Katy");
            }
            //For4
            Console.WriteLine(" How many crickets? For4");
            for (int l = 12; l > 0; l--)
            {
                Console.WriteLine($"{l} chirping...");
            }

            //For 5
            Console.WriteLine(" How many dove? For5");
            for (int ii = 3; ii < 5; ii++)
            {
                Console.WriteLine($"{ii} coo coo coo");
            }

            //For 6
            Console.WriteLine(" how do you do? Huck For6");

            var howdy = Console.ReadLine();
            for (int index = 1; index < 3; index++)
            {
                Console.WriteLine($"Hello {howdy} Say when in {index} minutes");

                var hello = Console.ReadLine();
                for (int i2 = 1; i2 < 3; i2++)
                {
                    Console.WriteLine($"Hello {hello} Say when in {i2} minutes");
                }

            }
            int number = 13;
            If (number / 2 % == 0 )? return "Even" : return "Odd";
            //for 7
            for (int mm = 5; mm < 0; mm++)
            {
                Console.WriteLine($"Hello 7 {mm} ");
            }
        }
    }
}

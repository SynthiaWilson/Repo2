using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace RandomPhrasesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var list = new List<string> { "Grin like a possum eating sweet tators", "Butter my Butt and call me a Biscuit!", "Crank my tractor", "Let sleeping Dogs Lie" };


                Console.WriteLine("Hey what are you doing today?");
                var userAnswer = Console.ReadLine();
                Console.WriteLine("Do you bet?");
                userAnswer = Console.ReadLine();

            Console.WriteLine("");
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);


            Console.WriteLine("Bless your heart!");
        }
    }
}

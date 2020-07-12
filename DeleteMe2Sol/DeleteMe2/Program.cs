using System;

namespace DeleteMe2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine($"What is your fictional or nickname?");
            string ficName = Console.ReadLine();

            Console.WriteLine($"How many siblings do you have?");
            string numSiblings = Console.ReadLine();
            Console.WriteLine($"Name a household item that you keep clean");
            string ficHouseHoldItem = Console.ReadLine();
            Console.WriteLine($"Enter an adjective that starts with the first letter of your last name");
            string ficAdj = Console.ReadLine();

            Console.WriteLine($"Name an item that you lose or misplace often.");
            string ficLostItem = Console.ReadLine();

           // MyMethod("Once upon a time there was a young girl named {ficName}");
            Console.WriteLine($"{ficName} has {numSiblings} horrid sisters,\n");
            Console.WriteLine($"{ficName}! It is your job to clean the {ficHouseHoldItem},\n");
            Console.WriteLine($"it seems {ficName} you lost a glass {ficLostItem} at a {ficAdj} Ball \n");
            Console.WriteLine($"Congrats {ficName} a representative from the ball will return your glass {ficLostItem} if it fits. Wink. \n");

            


        }
        public static void MyMethod(string text)
        {
            Console.WriteLine(text);

        }



    }
}

using System;
using System.Transactions;

namespace SwitchCaseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess a number between 1-1000.");
        
        var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);
            if (userInput < favNumber)
            {
                Console.WriteLine($"Low guess {userInput}. The number is {favNumber}.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"High guess {userInput}. The number is {favNumber}");
            } else
            {
                Console.WriteLine($"Great Guess {userInput}! Randon number {favNumber} You are correct.");
            }
            //***** Complete Part 1 of exercise
            Console.WriteLine("Enter your favorite topic:");
            var favTopic = (Console.ReadLine());
            switch (favTopic)
            {
                case "Math":
                    Console.WriteLine("That adds up Math rocks!");
                    break;
                case "English":
                    Console.WriteLine("To be or not to be? I love English");
                    break;
                case "Gym":
                    Console.WriteLine("One who likes to be active. Gym makes me move.");
                    break;
                case "Chemistry":
                    Console.WriteLine("Elemental. My Chemistry friend");
                    break;
                case "Biology":
                    Console.WriteLine("Get back to nature. Dissect it. Biology");
                    break;
                default:
                    Console.WriteLine("Other class... {favTopic}");
                    break;
            }
            string topic;
            topic = "Inheritance";
            string category = "";
            switch (topic)
            {
                case "Inheritance":
          
                case "Constructors":
                    Console.WriteLine("Constructors!");
                    break;
                default:
                    Console.WriteLine("Not Mentioned");
                    break;
            }
            Console.WriteLine("category is" + category);
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scoodby Doo", "Snoopy", "Old Yeller", "Lassie" };
            var dogSpaces = from dog in dogs
                            where dog.Contains(' ')
                            orderby dog ascending
                            select dog;



            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var filteredDogs = dogs.Where(x => x.Contains(" ")).OrderBy(x => x);

            foreach (var dog in filteredDogs)
            {
                Console.WriteLine(dog);
            }


            string[] cars = { "BMW", "Mercedes", "Dodge", "Tesla", "Ford Fusion", "Jeep" };
            var carSpaces = from car in cars
                            where car.Contains(' ')
                            orderby car ascending
                            select car;

            foreach (var i in carSpaces)
            {
                Console.WriteLine(i);
            }

            List<int> numbers = new List<int>  { 1,1,2,3,4,5,66,7,8,11};
            numbers.RemoveAll(x => x == 1);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //
            List<string> games = new List<string> { "Treasure Hunt", "PacMac", "Donkey Kong", "Prince Charming", "RPG Cinderella" };

            var filteredGames = games.OrderBy(x => x.Length);

            foreach (var i in filteredGames)
            {
                Console.WriteLine(i);
            }
            

        }

    }
    }
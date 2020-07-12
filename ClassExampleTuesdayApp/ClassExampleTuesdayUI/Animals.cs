using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassExampleTuesdayUI
{
    class Animals
    {
        
            public class Animal
        {
            public Animal()
            {

            }
            public int Legs { get; set; }
            public int Age { get; set; }
        }

        public class Dog : Animal
        {
            public Dog()
            {
                Legs = 4;
            }
            public string OwnerName { get; set; }
            public string FavoriteToy { get; set; }
        }

        public class Labrador : Dog
        {

        }

    }
}

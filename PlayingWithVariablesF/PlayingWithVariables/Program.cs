using System;

namespace PlayingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 10;
            char dogType = '*';
            bool dogIsAlive = true;

            float dogCost = 33.3f;

            double dogDouble = 4.321234555555;

            decimal dogHairPercentage = 99.5m;


            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old,\n He is a {dogType}\n My dog is alive {dogIsAlive} \n My dog costs ${dogCost} \n My dog's hertz is {dogDouble} \n My dog has this percentage of hair % {dogHairPercentage}");
        }
    }
}

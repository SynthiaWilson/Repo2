using System;

namespace StaticExerciseUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int ctemp = TempConverter.FahrenheitToCelsius(32);
            int fTemp = TempConverter.CelsiusToFahrenheit(0);

            Console.WriteLine($" 32F = {ctemp} in Celsius");
            Console.WriteLine($" 0C = {fTemp} in Farenheit");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StaticExerciseUI
{
   public static class TempConverter
    {
        public static int FahrenheitToCelsius(int temp)
        {

            return (temp - 32) / (9 / 5);
        }
        public  static int CelsiusToFahrenheit(int temp)
        {
            return (temp * (9 / 5)) + 32;
        }
    }
}

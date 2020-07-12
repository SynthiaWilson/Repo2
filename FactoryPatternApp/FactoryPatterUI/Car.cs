using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterUI
{
    public class Car : IVehicle
    {
        public Car()
        { 
        }
        public void Drive()
        {
            Console.WriteLine("This car is in Drive Mode!");
        }
    }
}

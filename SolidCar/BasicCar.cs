using System;
using System.Collections.Generic;

namespace SolidCar
{
    public class BasicCar : ICar
    {
        public BasicCar()
        {
        }

        public string Name
        {
            get; set;
        }

        public void Drive()
        {
            //We assume evey car can go using same way.
            //It is not changeable car by car, so we don't mark as virtual.
            Console.WriteLine($"{Name} car is going");
        }

        public virtual List<string> GetModules()
        {
            //We assume evey car have a water cooler module and radio module.
            //But maybe some kind of car has another basic modules, so we mark as virtual
            return new List<string>() { "Water Cooler Module", "Radio Module" };
        }
    }
}

using System;
using System.Collections.Generic;

namespace SolidCar
{
    public class BMWCar : BasicCar, I4MotionCar
    {
        //A BMW car is a car and also is a 4motion car.
        //BMW has to implement getting 4motion modules.
        //But it is also a basic car . It doesn't have to implement drive method and name mothod.

        public BMWCar()
        {
        }
        public List<object> Get4MotionModules()
        {
            return new List<object>() { "4x4 Module", "Air Suspansion Module" };
        }
    }
}

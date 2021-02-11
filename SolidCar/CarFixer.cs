using System;
using System.Collections.Generic;

namespace SolidCar
{
    public class CarFixer
    {
        public CarFixer()
        {
        }

        //CarFixer class impletements open-closed and single responsibility patterns
        //It is responsible for fixing cars and closed to add new responsibilities.
        //But it is also open to extensions such as fixing a 4motion car.

        public void FixTheCar(ICar car)
        {
            List<string> fixedModules = car.GetModules();

            foreach (var fixedModule in fixedModules)
            {
                Console.WriteLine($"{fixedModule} are fixed by car fixer - FixTheCar");
            }
        }


        //It can also fix a 4motion car without any changes in a basic car fixing.
        public void FixThe4MotionCar(I4MotionCar i4MotionCar)
        {
            List<object> fixed4MotionModules = i4MotionCar.Get4MotionModules();
            foreach (var fixedModule in fixed4MotionModules)
            {
                Console.WriteLine($"{fixedModule} are fixed by car fixer - FixThe4MotionCar");
            }
        }
    }
}

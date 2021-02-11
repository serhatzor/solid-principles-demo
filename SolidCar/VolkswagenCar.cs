using System;
using System.Collections.Generic;

namespace SolidCar
{
    public class VolkswagenCar : BasicCar
    {
        public VolkswagenCar()
        {
        }

        //This class implements liskov subsutition rule .
        //Getmodules method doesn't return unrelated things. It just add a new module to the basic modules collection which is included only in a volkswagen car.
        public override List<string> GetModules()
        {
            List<string> modules = base.GetModules();
            if (modules == null)
                modules = new List<string>();
            modules.Add("DSG Tranmission");

            return modules;
        }
    }
}

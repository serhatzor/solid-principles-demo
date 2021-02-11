using System;
using System.Collections.Generic;

namespace SolidCar
{
    public interface ICar
    {
        //Every car have to implement drive method, a name and a getmodules method.
        string Name { get; set; }
        List<string> GetModules();
        void Drive();
    }
}

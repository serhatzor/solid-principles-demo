using System;
using System.Collections.Generic;

namespace SolidCar
{
    public interface I4MotionCar
    {
        //Every 4Motion car have to implement another modules depend on 4motion system and it can be very different.
        //This interface let us to implement interface segregation rule, because a basic car doesn't have to implement get4motion modules.
        List<object> Get4MotionModules();
    }
}

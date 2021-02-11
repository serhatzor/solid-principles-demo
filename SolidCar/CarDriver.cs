using System;
namespace SolidCar
{
    public class CarDriver
    {
        //This class implements dependency inversion rule.
        //It just now the drive method.
        //We don't have to use drive method for every car instance.
        //For example , when we have to change drive method , we can only the usage drive method in this class.
        private ICar car;
        public CarDriver(ICar car)
        {
            this.car = car;
        }

        public void Drive()
        {
            car.Drive();
        }
    }
}

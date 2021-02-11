using System;
using SolidCar;

namespace SolidPrinciplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFixer carFixer = new CarFixer();

            BasicCar basicCar = new BasicCar() { Name = "A Basic Car" };
            CarDriver basicCarDriver = new CarDriver(basicCar);

            BMWCar bMWCar = new BMWCar() { Name = "A BMW Car" };
            CarDriver bmwCarDriver = new CarDriver(bMWCar);

            VolkswagenCar volkswagenCar = new VolkswagenCar() { Name = "A Volkswagen Car" };
            CarDriver vwCarDriver = new CarDriver(volkswagenCar);


            carFixer.FixTheCar(basicCar);
            basicCarDriver.Drive();

            carFixer.FixTheCar(bMWCar);
            carFixer.FixThe4MotionCar(bMWCar);
            bmwCarDriver.Drive();

            carFixer.FixTheCar(volkswagenCar);
            vwCarDriver.Drive();


            Console.Read();
        }
    }
}
using System;
using Assignment1.Engine;
using Assignment1.CarBrands;
using Assignment1.stuff;
using Assignment1.Vehicles;
using Assignment1.ColourDecoration;
namespace Assignment1
{
    public class CarFactory : IAbstractVehicleFactory
    {
        private Brand brand;

        public Vehicle CreateAudiVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine)
        {
            this.brand = new Audi(name);

            return new Car(carColour, wheel, brand, numberplate, engine);
        }

        public Vehicle CreateBMWVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine)
        {
            this.brand = new BMW(name);

            return new Car(carColour, wheel, brand, numberplate, engine);
        }

        public Vehicle CreateFordVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine)
        {
            this.brand = new Ford(name);

            return new Car(carColour, wheel, brand, numberplate, engine);
        }

        public Vehicle CreateMercedesVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine)
        {
            this.brand = new Mercedes(name);

            return new Car(carColour, wheel, brand, numberplate, engine);
        }

        public Vehicle CreateVWVehicle(string name, CarColour carColour, IWheel wheel ,Numberplate numberplate, EngineClass engine)
        {
            this.brand = new VW(name);

            return new Car(carColour, wheel, brand, numberplate, engine);
        }

        public Vehicle CreateVehicle(CarColour carColour, IWheel wheel, Brand brand, Numberplate numberplate, EngineClass engine)
        {
            return new Car(carColour, wheel, brand, numberplate, engine);
        }


    }
}
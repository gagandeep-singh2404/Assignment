using System;
using Assignment1.Engine;
using Assignment1.ColourDecoration;
using Assignment1.Main;

namespace Assignment1.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(ICarColour carColour, IWheel wheel, Brand brand, Numberplate numberplate, EngineClass engine)
        :
        base(carColour, wheel, brand, numberplate, engine)
        {
           
        }

        public override string Description()
        {
            return "Vehicle: Truck";
        }
    }
}

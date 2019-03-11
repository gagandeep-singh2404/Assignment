using System;
using Assignment1.Vehicles;
using Assignment1.Engine;
using Assignment1.ColourDecoration;
namespace Assignment1.stuff

{
    public interface IAbstractVehicleFactory
    {
        Vehicle CreateVehicle(CarColour carColour, IWheel wheel, Brand brand, Numberplate numberplate, EngineClass engine);

        Vehicle CreateBMWVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine);
        Vehicle CreateVWVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine);
        Vehicle CreateFordVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine);
        Vehicle CreateMercedesVehicle(string name, CarColour carColour, IWheel wheel, Numberplate numberplate, EngineClass engine);
        Vehicle CreateAudiVehicle(string name,CarColour carColour, IWheel whee, Numberplate numberplate, EngineClass engine);
    
    }
}
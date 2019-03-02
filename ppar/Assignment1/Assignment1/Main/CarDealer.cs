using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Vehicles;
using Assignment1.ColourDecoration;
using Assignment1.CarBrands;
using Assignment1.Engine;

namespace Assignment1.Main
{
    public class CarDealer
    {

        public CarDealer() { }

        List<Vehicle> vehicles = new List<Vehicle>();

        public List<Vehicle> Vehicles { get { return vehicles; } }

        public void AddVehicleToList(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public Type[] GetArrayOfCarColours()
        {
            var type = typeof(ICarColour);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToArray();

            return types;
        }

        public Type[] GetArrayOfColourDecos()
        {
            var type = typeof(IColourDecoration);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToArray();

            return types;
        }

        public Type[] GetArrayOfCarWheels()
        {
            var type = typeof(IWheel);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToArray();

            return types;
        }

        public Type[] GetArrayOfWheelDecos()
        {
            var type = typeof(IWheelDeco);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToArray();

            return types;
        }

        public Type[] GetArrayOfBrands()
        {
            var type = typeof(Brand);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToArray();

            return types;
        }

        public Type[] GetArrayOfEngines()
        {
    
            var type = typeof(EngineClass);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToArray();

            return types;
        }


    }

}
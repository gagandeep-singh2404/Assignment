using System;
using System.Collections.Generic;
using Assignment1.Vehicles;

namespace Assignment1.Command
{
    public class NumberOfAvailableVehiclesCommand: ICommand
    {
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles { set { vehicles = value; } }



        public void Execute()
        {
            Console.WriteLine("Total Value of available cars: " + vehicles.Count);
            Console.WriteLine("Type \"yes\" to see the cars");

            if (Console.ReadLine().ToLower() == "yes")
            {
                ICommand command = new PrintVehicleCommand {List = vehicles };
                command.Execute();
            }
        }
    }
}

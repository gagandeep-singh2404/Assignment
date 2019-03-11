using System;
using System.Collections.Generic;
using Assignment1.Vehicles;

namespace Assignment1.Command
{
    public class PrintVehicleCommand : ICommand
    {
        private List<Vehicle> vehicleList;
        public List<Vehicle> List
        {
            set { vehicleList = value; }
        }


        public void Execute()

        {
            if (vehicleList.Count == 0)
            {
                Console.WriteLine("There is no car in the List");
            }
            else { vehicleList.ForEach(Console.WriteLine);}
        }
    }
}

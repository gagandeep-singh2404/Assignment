using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Vehicles;

namespace Assignment1.Command
{
    public class ShowTotalSumCommand: ICommand
    {
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles { set { vehicles = value; } }

        public void Execute()
        {
            Console.WriteLine("The total sum of all Vehicles: "+ (double)vehicles.Sum(x => x.Price));
        }
    }
}

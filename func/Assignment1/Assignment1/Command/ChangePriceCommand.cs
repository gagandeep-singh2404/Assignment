using System;
using System.Collections.Generic;
using Assignment1.Main;
using Assignment1.Vehicles;

namespace Assignment1.Command
{
    public class ChangePriceCommand : ICommand
    {
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles { set { vehicles = value; } }

    

        public void Execute()
        {

            Console.Write("Please enter the precentage of how much you want to change the prices.\nYou can also decrease the prices by choosing a negative precentage!" +
                "\n\nPlease consider the right format: 0.X: " );
            double decision;
            try
            {
                decision = double.Parse(Console.ReadLine());
            }catch(System.FormatException) { Console.WriteLine("We could not handle your decision"); return; }


            vehicles.ForEach(x => x.Price += x.Price * decision);

            Console.WriteLine("The prices are successfully changed");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Vehicles;
namespace Assignment1.Command
{
    public class SearchVehicleCommand : ICommand
    {
        ICommand command;
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles { set { vehicles = value; } }


        public void Execute()
        {


            Dictionary<string, Action> searchOptions = new Dictionary<string, Action>
            {
                ["range"] = SearchWithinPriceRange,
                ["lp"] = SearchWithLicensePlate,
                ["id"] = SearchWithId
            };

            bool choice = false;
            string decision;
           
           do
            {
                Console.WriteLine("Please enter how you want to search for your car: " +
                            "\n Press \"range\" for searching withhin a price range " +
                            "\n Press \"lp\" for searching with a License PLate. Is has not to be completed" +
                            "\n Press \"id\" for searching with an ID");

                decision = Console.ReadLine();

                if (searchOptions.ContainsKey(decision))
                {
                    searchOptions[decision]();
                    choice = true;
                }

            } while (!choice);

        }


        public void SearchWithinPriceRange()
        {
            double min;
            double max;

            Console.WriteLine("Enter Minimum Price: ");
            min = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maximum Price: ");
            max = double.Parse(Console.ReadLine());

            var listOfCars = from veh in vehicles
                             where veh.Price <= max && veh.Price >= min
                             orderby veh.Price
                             select veh;

            command = new PrintVehicleCommand { List = listOfCars.ToList() };
            command.Execute();

        }


        public void SearchWithLicensePlate()
        {
            string decision;
            Console.WriteLine("Enter the licenseplate: ");
            decision = Console.ReadLine();

            var listOfCars = from veh in vehicles
                             where veh.Numberplate.SpecificNumberplate.Contains(decision)
                             orderby veh.Numberplate.SpecificNumberplate
                             select veh;

            command = new PrintVehicleCommand { List = listOfCars.ToList() };
            command.Execute();
        }

        public void SearchWithId()
        {
            int decision;
            Console.WriteLine("Enter the id of the car: ");
            try
            {
                decision = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException) { Console.WriteLine("We could not handle your decision");return; };
            var listOfCars = from veh in vehicles
                             where veh.ID == decision
                             select veh;

            command = new PrintVehicleCommand { List = listOfCars.ToList() };
            command.Execute();
        }
    }
}

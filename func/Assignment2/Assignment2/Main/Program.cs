﻿using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommand command;
         

            bool continueLoop = true;
            string decision;

            do
            {
                Console.WriteLine("Welcome Mr. Douchebag " +
                "\r\nPress \"help\" to see the list of Commands");
                decision = Console.ReadLine();

                switch (decision)
                {
                    case "help":
                        command = new HelpCommand();
                        break;
                    case "0":
                        command = new PrintVehicleCommand() { List = carDealer.Vehicles };
                        break;
                    case "1":
                        command = new NumberOfAvailableVehiclesCommand() { Vehicles = carDealer.Vehicles };
                        break;
                    case "2":
                        command = new AddVehicleCommand(carDealer);
                        break;
                    case "3":
                        command = new ChangePriceCommand() { Vehicles = carDealer.Vehicles };
                        break;
                    case "4":
                        command = new SearchVehicleCommand() { Vehicles = carDealer.Vehicles };
                        break;
                    case "5":
                        command = new ShowTotalSumCommand() { Vehicles = carDealer.Vehicles };
                        break;
                    case "q":
                        continueLoop = false;
                        command = null;
                        break;
                    default:
                        command = null;
                        break;
                }

                if (command != null)
                {
                    command.Execute();
                }

            } while (continueLoop);
        }
    }
}

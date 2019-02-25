using System;
using Assignment2.Commands;
using System.Configuration;
using System.Collections.Specialized;

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
                Console.WriteLine("Welcome Mrs. Douchebag " +
                "\r\nPress \"help\" to see the list of Commands");
                decision = Console.ReadLine();

                switch (decision)
                {
                    case "help":
                        command = new HelpCommand();
                        break;
                    case "0":
                        command = new AddCommand();
                        break;
                    case "1":
                        command = new ShowOverviewCommand();
                        break;
                    case "2":
                        command = new SpecificSearchCommand();
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

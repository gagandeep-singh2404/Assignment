using System;
using System.Collections.Generic;

namespace Assignment1.Command
{
    public class HelpCommand: ICommand
    {
       
        public void Execute()
        {
            List<string> commandList = new List<string> { "0.) to see list of vehicle",
                                        "1.) to see available number of Vehicle",
                                        "2.) to add Vehicle",
                                        "3.) to change Price of Vehicle",
                                        "4.) search for Vehicle",
                                        "5.) show the total sum of all Vehicles",
                                        "q.) to Quiet"};
            commandList.ForEach(Console.WriteLine);
        }
    }
}

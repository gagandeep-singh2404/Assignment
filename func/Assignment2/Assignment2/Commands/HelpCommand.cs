using System;
using System.Collections.Generic;

namespace Assignment2.Commands
{
    public class HelpCommand : ICommand
    {
        public void Execute()
        {
            List<string> commandList = new List<string> { 
                                        "0.) Create user)",                                         "1.) Show overview users in database ",                                         "2.) Show user details",                                         "q.) Exit application"};             commandList.ForEach(Console.WriteLine);
        }
    }
}

using System;
namespace Assignment2.Commands
{
    public class Command
    {
    
        public Action SpecificAction { get; set; }
        public string Desc { get; set; }

        public void Execute() { SpecificAction(); }
    }
}

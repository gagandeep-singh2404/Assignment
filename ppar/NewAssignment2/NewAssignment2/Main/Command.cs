using System;
namespace NewAssignment2.Main
{
    public class Command
    {

        public Action SpecificAction { get; set; }
        public string Desc { get; set; }

        public void Execute() { SpecificAction(); }
    }
}

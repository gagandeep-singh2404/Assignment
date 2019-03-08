using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationAssignment.Main
{
    public class Command
    {

        public Action SpecificAction { get; set; }
        public string Desc { get; set; }

        public void Execute() { SpecificAction(); }
    }
}
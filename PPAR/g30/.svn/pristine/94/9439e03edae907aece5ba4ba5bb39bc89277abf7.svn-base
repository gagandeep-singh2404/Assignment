using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.WheelDecorations
{
    public class Winter : IWheel
    {
        private IWheelDeco decorations;

        public Winter(IWheelDeco decorations)
        {
            this.decorations = decorations;
        }

        public double Price()
        {
            return decorations.Price()+ 300;
        }

        public string Description()
        {
            return "Wheel: Summer" + decorations.Description();
        }
    }
}

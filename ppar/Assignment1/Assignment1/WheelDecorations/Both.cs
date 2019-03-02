using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.WheelDecorations
{
    public class Both: IWheel
    {
        private IWheelDeco decorations;

        public Both(IWheelDeco decorations)
        {
            this.decorations = decorations;
        }

        public double Price()
        {
            return decorations.Price() + 300;
        }

        public string Description()
        {
            return "Wheel: Summer and Winter" + decorations.Description(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.WheelDecorations
{
    public class Summer: IWheel
    {
        private IWheelDeco decorations;

        public Summer(IWheelDeco deco)
        {
            this.decorations = deco;
        }

        public double Price()
        {
            return decorations.Price() + 300;
        }

        public string Description()
        {
            return "Wheel: Summer" + decorations.Description();
        }
    }
}

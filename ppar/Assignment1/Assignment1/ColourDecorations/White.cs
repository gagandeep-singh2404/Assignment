using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.ColourDecoration
{
    public class White: ICarColour
    {
        private IColourDecoration decorations;

        public White(IColourDecoration  decorations)
        {
            this.decorations = decorations;
        }

        public double CalculatePrice()
        {
            return decorations.GetPrice() + 300;
        }

        public string Description()
        {
            return "Color: White" + decorations.GetDescription();
        }
    }
}

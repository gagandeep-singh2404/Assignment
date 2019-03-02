using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.ColourDecoration
{
    public class Silver : ICarColour
    {
        private IColourDecoration decorations;

        public Silver(IColourDecoration decorations)
        {
            this.decorations = decorations;
        }

        public double CalculatePrice()
        {
            return decorations.GetPrice() + 600;
        }

        public string Description()
        {
            return "Color: Silver" + decorations.GetDescription();
        }
    }
}

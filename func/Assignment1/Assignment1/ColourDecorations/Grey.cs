using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.ColourDecoration
{
    public class Grey : ICarColour
    {
        private IColourDecoration decorations;

        public Grey(IColourDecoration decorations)
        {
            this.decorations = decorations;
        }

        public double CalculatePrice()
        {
            return this.decorations.GetPrice()+ 400;
        }

        public string Description()
        {
            return "Color: Grey" + decorations.GetDescription();
        }
    }
}

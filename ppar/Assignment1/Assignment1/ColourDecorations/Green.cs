using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.ColourDecoration
{
    public class Green : ICarColour
    {
        private IColourDecoration decorations;

        public Green(IColourDecoration decorations)
        {
            this.decorations = decorations;
        }

        public double CalculatePrice()
        {
            return this.decorations.GetPrice() + 400;
        }

        public string Description()
        {
            return "Color: Green"+ decorations.GetDescription(); 
        }
    }
}

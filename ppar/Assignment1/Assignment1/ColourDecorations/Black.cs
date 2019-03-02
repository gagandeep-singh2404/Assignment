using System;

namespace Assignment1.ColourDecoration
{
    public class Black : ICarColour
    {

        private IColourDecoration decorations;

        public Black(IColourDecoration decorations)
        {
            this.decorations = decorations;
        }

        public double CalculatePrice()
        {
            return this.decorations.GetPrice() + 600;
        }

        public string Description()
        {
            return "Color: Black" + decorations.GetDescription();
        }
    }
}

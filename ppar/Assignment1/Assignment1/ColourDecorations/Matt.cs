using System;
namespace Assignment1.ColourDecoration
{
    public class Matt : IColourDecoration
    {

        public Matt()
        {
        }

        public string GetDescription()
        {
           return ",Uni-Colour: Matt";
        }

        public double GetPrice()
        {
            return 1000;
        }
    }
}

using System;
namespace Assignment1.ColourDecoration
{
    public class Metallic : IColourDecoration
    {
        public Metallic()
        {
        }

        public string GetDescription()
        {
            return ", Uni-Colour: Metallic"; 
        }

        public double GetPrice()
        {
            return 1000;
        }
    }
}

using System;
namespace Assignment1.WheelDecorations
{
    public class SteelRims: IWheelDeco
    {
        public string Description()
        {
            return "Rims: Steel";
        }

        public double Price()
        {
            return 200; 
        }
    }
}

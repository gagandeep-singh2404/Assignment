using System;
namespace Assignment1.WheelDecorations
{
    public class AluRims : IWheelDeco
    {
        public string Description()
        {
            return "Rims: Aluminium";
        }

        public double Price()
        {
            return 100;
        }
    }
}
